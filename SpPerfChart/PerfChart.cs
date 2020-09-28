using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace SpPerfChart
{
    public class DataSample
    {
        public Int32[] value;

        public DataSample()
        {
            value = new Int32[4];
            value[0] = 0;
            value[1] = 0;
            value[2] = 0;
            value[3] = 0;
        }
    }

    /// <summary>
    /// Chart Refresh Mode Timer Control Mode
    /// </summary>
    public enum TimerMode
    {
        /// <summary>
        /// Chart is refreshed when a value is added
        /// </summary>
        Disabled,
        /// <summary>
        /// Chart is refreshed every <c>TimerInterval</c> milliseconds, adding all values
        /// in the queue to the chart. If there are no values in the queue, a 0 (zero) is added
        /// </summary>
        Simple,
        /// <summary>
        /// Chart is refreshed every <c>TimerInterval</c> milliseconds, adding an average of
        /// all values in the queue to the chart. If there are no values in the queue,
        /// 0 (zero) is added
        /// </summary>
        SynchronizedAverage,
        /// <summary>
        /// Chart is refreshed every <c>TimerInterval</c> milliseconds, adding the sum of
        /// all values in the queue to the chart. If there are no values in the queue,
        /// 0 (zero) is added
        /// </summary>
        SynchronizedSum
    }


    public partial class PerfChart : UserControl
    {
        #region *** Constants ***

        // Keep only a maximum MAX_VALUE_COUNT amount of values; This will allow
        //private const int MAX_VALUE_COUNT = 512;
        // Draw a background grid with a fixed line spacing
        private const int GRID_SPACING = 16;

        #endregion


        #region *** Member Variables ***

        // Horizontal value space in Pixels
        private int valueSpacing = 1;
        // The currently highest displayed value, required for Relative Scale Mode
        private Int32[] currentMaxValue = new Int32[4] ;
        // The currently lowest displayed value, required for Relative Scale Mode
        private Int32[] currentMinValue = new Int32[4] ;
        // Offset value for the scrolling grid
        private int gridScrollOffset = 0;
        // The current average value
        private Int32 averageValue = 0;
        // Border Style
        private Border3DStyle b3dstyle = Border3DStyle.Sunken;
        // Timer Mode
        private TimerMode timerMode;
        // List of stored values
        private List<DataSample> drawValues;
        // Value queue for Timer Modes
        private ConcurrentQueue<DataSample> waitingValues;
        // Style and Design
        private PerfChartStyle perfChartStyle;
        private PerfChartPenStyle[] perfChartPenStyles;

        private int chartSize;
        private int chartOffset;

        #endregion


        #region *** Constructors ***

        public PerfChart() {
            InitializeComponent();

            // Initialize Variables
            perfChartStyle = new PerfChartStyle();

            perfChartPenStyles = new PerfChartPenStyle[4];
            perfChartPenStyles[0] = new PerfChartPenStyle();
            perfChartPenStyles[1] = new PerfChartPenStyle();
            perfChartPenStyles[2] = new PerfChartPenStyle();
            perfChartPenStyles[3] = new PerfChartPenStyle();

            chartSize = 500;
            drawValues = new List<DataSample>(chartSize);
            waitingValues = new ConcurrentQueue<DataSample>();

            // Set Optimized Double Buffer to reduce flickering
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // Redraw when resized
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            this.Font = SystemInformation.MenuFont;
        }

        #endregion


        #region *** Properties ***

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Category("Appearance"), Description("Appearance and Style")]
        public PerfChartStyle PerfChartStyle {
            get { return perfChartStyle; }
            set { perfChartStyle = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Category("Appearance"), Description("Appearance and Style")]
        public PerfChartPenStyle[] PerfChartPenStyles
        {
            get { return perfChartPenStyles; }
            set { perfChartPenStyles = value; }
        }

        [DefaultValue(typeof(Border3DStyle), "Sunken"), Description("BorderStyle"), Category("Appearance")]
        new public Border3DStyle BorderStyle {
            get {
                return b3dstyle;
            }
            set {
                b3dstyle = value;
                Invalidate();
            }
        }

        public TimerMode TimerMode {
            get { return timerMode; }
            set {
                if (value == TimerMode.Disabled) {
                    // Stop and append only when changed
                    if (timerMode != TimerMode.Disabled) {
                        timerMode = value;

                        tmrRefresh.Stop();
                        // If there are any values in the queue, append them
                        ChartAppendFromQueue();
                    }
                }
                else {
                    timerMode = value;
                    tmrRefresh.Start();
                }
            }
        }

        public int TimerInterval {
            get { return tmrRefresh.Interval; }
            set {
                if (value < 15)
                    throw new ArgumentOutOfRangeException("TimerInterval", value, "The Timer interval must be greater then 15");
                else
                    tmrRefresh.Interval = value;
            }
        }

        public int ChartSize
        {
            get
            {
                return chartSize;
            }
            set
            {
                chartSize = value;
                drawValues = new List<DataSample>(chartSize);
            }
        }

        public int ChartOffset {
            get
            {
                return chartOffset;
            }
            set
            {
                chartOffset = value;
                Invalidate();
            }
        }

        // Amount of currently visible values (calculated from control width and value spacing)
        public int VisibleValues { get; set; } = 0;

        //public int VisibleValues { get; set; } = 0;

        #endregion


        #region *** Public Methods ***

        /// <summary>
        /// Clears the whole chart
        /// </summary>
        public void Clear() {
            drawValues.Clear();
            Invalidate();
        }


        /// <summary>
        /// Adds a value to the Chart Line
        /// </summary>
        /// <param name="value">progress value</param>
        public void AddValue(DataSample values) {
            switch (timerMode) {
                case TimerMode.Disabled:
                    ChartAppend(values);
                    Invalidate();
                    break;
                case TimerMode.Simple:
                case TimerMode.SynchronizedAverage:
                case TimerMode.SynchronizedSum:
                    // For all Timer Modes, the Values are stored in the Queue
                    AddValueToQueue(values);
                    break;
                default:
                    throw new Exception(String.Format("Unsupported TimerMode: {0}", timerMode));
            }
        }

        #endregion


        #region *** Private Methods: Common ***

        /// <summary>
        /// Add value to the queue for a timed refresh
        /// </summary>
        /// <param name="value"></param>
        private void AddValueToQueue(DataSample sample) {
            waitingValues.Enqueue(sample);
        }


        /// <summary>
        /// Appends value <paramref name="value"/> to the chart (without redrawing)
        /// </summary>
        /// <param name="value">performance value</param>
        private void ChartAppend(DataSample value) {
            // Insert at first position
            drawValues.Insert(0, value);

            // Remove last item if maximum value count is reached
            if (drawValues.Count > chartSize)
                drawValues.RemoveAt(chartSize);

            // Calculate horizontal grid offset for "scrolling" effect
            gridScrollOffset += valueSpacing;
            if (gridScrollOffset > GRID_SPACING)
                gridScrollOffset = gridScrollOffset % GRID_SPACING;
        }


        /// <summary>
        /// Appends Values from queue
        /// </summary>
        private void ChartAppendFromQueue() {
            // Proceed only if there are values at all
            if (waitingValues.Count > 0) {
                if (timerMode == TimerMode.Simple) {
                    DataSample s;
                    Debug.WriteLine("Dequeue:" + waitingValues.Count.ToString());
                    while (!waitingValues.IsEmpty)
                    {
                        if (waitingValues.TryDequeue(out s))
                        {
                            ChartAppend(s);
                        }
                    }
                }
                else if (timerMode == TimerMode.SynchronizedAverage ||
                         timerMode == TimerMode.SynchronizedSum) {
                    // appendValue variable is used for calculating the average or sum value
                    DataSample appendValue = new DataSample();
                    int valueCount = waitingValues.Count;

                    DataSample s;
                    while (!waitingValues.IsEmpty)
                    {
                        if (waitingValues.TryDequeue(out s))
                        {
                            ChartAppend(s);
                            appendValue.value[0] += s.value[0];
                            appendValue.value[1] += s.value[1];
                            appendValue.value[2] += s.value[2];
                            appendValue.value[3] += s.value[3];
                        }
                    }

                    //TODO: restore average mode
                    // Calculate Average value in SynchronizedAverage Mode
                    //if (timerMode == TimerMode.SynchronizedAverage)
                    //    appendValue = appendValue / valueCount;

                    // Finally append the value
                    ChartAppend(appendValue);
                }
            }
            else {
                // Always add 0 (Zero) if there are no values in the queue
                ChartAppend(new DataSample());
            }

            // Refresh the Chart
            Invalidate();
        }

        /// <summary>
        /// Calculates the vertical Position of a value in relation the chart size,
        /// Scale Mode and, if ScaleMode is Relative, to the current maximum value
        /// </summary>
        /// <param name="value">performance value</param>
        /// <returns>vertical Point position in Pixels</returns>
        private double CalcVerticalPosition(PerfChartPenStyle pt, Int32 value) {
            double result = 0;

            if (pt.ScaleMode == ScaleMode.Absolute)
            {
                result = (((double)value + pt.Offset) / pt.Scale) * (double)this.Height;
            }
            else if (pt.ScaleMode == ScaleMode.Relative)
            {
                result = (pt.currentMaxValue > 0) ? (value * this.Height / pt.currentMaxValue) : 0;
            }

            // Invert the graph to have Y going up
            result = this.Height - result;

            return result;
        }


        /// <summary>
        /// Calculate the currently highest and lowest value, for Relative ScaleMode
        /// and put the result in the Pen data area
        /// </summary>
        /// <returns></returns>
        private void GetMinMaxValueForRelativeMode(int pt) {
            Int32 maxValue = Int32.MinValue;
            Int32 minValue = Int32.MaxValue;
            for (int i = 0; i < drawValues.Count; i++)
            {
                // Set if higher then previous max value
                if (drawValues[i].value[pt] > maxValue)
                    maxValue = drawValues[i].value[pt];
                if (drawValues[i].value[pt] < minValue)
                    minValue = drawValues[i].value[pt];
            }
            perfChartPenStyles[pt].currentMinValue = minValue;
            perfChartPenStyles[pt].currentMaxValue = maxValue;
        }

        #endregion


        #region *** Private Methods: Drawing ***

        /// <summary>
        /// Draws the chart (w/o background or grid, but with border) to the Graphics canvas
        /// </summary>
        /// <param name="g">Graphics</param>
        private void DrawChart(Graphics g) {
            int visibleValues = Math.Min(this.Width / valueSpacing, drawValues.Count);

            int startDisplay = Math.Min(drawValues.Count, chartOffset); ;
            int stopDisplay = Math.Min(drawValues.Count, visibleValues + chartOffset);

            // Dirty little "trick": initialize the first previous Point outside the bounds
            Point[] previousPoint = new Point[4];
            previousPoint[0] = new Point(Width + valueSpacing, Height);
            previousPoint[1] = new Point(Width + valueSpacing, Height);
            previousPoint[2] = new Point(Width + valueSpacing, Height);
            previousPoint[3] = new Point(Width + valueSpacing, Height);
            Point[] currentPoint = new Point[4];

            // Only draw average line when possible (visibleValues) and needed (style setting)
            //if (visibleValues > 0 && perfChartStyle.ShowAverageLine) {
            //    averageValue = 0;
            //    DrawAverageLine(g);
            //}

            // Connect all visible values with lines
            for (int pt = 0; pt < 4; pt++)
            {
                if (perfChartPenStyles[pt].ShowPen)
                {
                    GetMinMaxValueForRelativeMode(pt);
                    for (int i = startDisplay; i < stopDisplay; i++)
                    {
                        currentPoint[pt].X = previousPoint[pt].X - valueSpacing;
                        currentPoint[pt].Y = (int)CalcVerticalPosition(perfChartPenStyles[pt], drawValues[i].value[pt]);

                        // Actually draw the line
                        g.DrawLine(perfChartPenStyles[pt].ChartLinePen.Pen, previousPoint[pt], currentPoint[pt]);

                        previousPoint[pt] = currentPoint[pt];
                    }
                }
            }
            // Draw current relative maximum value stirng
            //if (scaleMode == ScaleMode.Relative) {
            //    SolidBrush sb = new SolidBrush(perfChartPenStyles[0].ChartLinePen.Color);
            //    g.DrawString(currentMaxValue.ToString(), this.Font, sb, 4.0f, 2.0f);
            //}

            // Draw Border on top
            ControlPaint.DrawBorder3D(g, 0, 0, Width, Height, b3dstyle);
        }


        //private void DrawAverageLine(Graphics g) {
        //    for (int i = 0; i < visibleValues; i++)
        //        averageValue += drawValues[i].value[0];

        //    averageValue = averageValue / visibleValues;

        //    int verticalPosition = CalcVerticalPosition(averageValue);
        //    g.DrawLine(perfChartPenStyles[0].AvgLinePen.Pen, 0, verticalPosition, Width, verticalPosition);
        //}

        /// <summary>
        /// Draws the background gradient and the grid into Graphics <paramref name="g"/>
        /// </summary>
        /// <param name="g">Graphic</param>
        private void DrawBackgroundAndGrid(Graphics g) {
            // Draw the background Gradient rectangle
            Rectangle baseRectangle = new Rectangle(0, 0, this.Width, this.Height);
            using (Brush gradientBrush = new LinearGradientBrush(baseRectangle, perfChartStyle.BackgroundColorTop, perfChartStyle.BackgroundColorBottom, LinearGradientMode.Vertical)) {
                g.FillRectangle(gradientBrush, baseRectangle);
            }

            // Draw all visible, vertical gridlines (if wanted)
            if (perfChartStyle.ShowVerticalGridLines) {
                for (int i = Width - gridScrollOffset; i >= 0; i -= GRID_SPACING) {
                    g.DrawLine(perfChartStyle.VerticalGridPen.Pen, i, 0, i, Height);
                }
            }

            // Draw all visible, horizontal gridlines (if wanted)
            if (perfChartStyle.ShowHorizontalGridLines) {
                for (int i = 0; i < Height; i += GRID_SPACING) {
                    g.DrawLine(perfChartStyle.HorizontalGridPen.Pen, 0, i, Width, i);
                }
            }
        }

        #endregion


        #region *** Overrides ***

        /// Override OnPaint method
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            // Enable AntiAliasing, if needed
            //if (perfChartStyle.AntiAliasing)
            //    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            DrawBackgroundAndGrid(e.Graphics);
            DrawChart(e.Graphics);
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);

            Invalidate();
        }

        #endregion


        #region *** Event Handlers ***

        private void colorSet_ColorSetChanged(object sender, EventArgs e) {
            //Refresh Chart on Resize
            Invalidate();
        }

        private void tmrRefresh_Tick(object sender, EventArgs e) {
            // Don't execute event if running in design time
            if (this.DesignMode) return;

            ChartAppendFromQueue();
        }

        #endregion
    }
}
