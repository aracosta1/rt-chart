using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace realtimeChart
{
    public partial class RealtimeChart : UserControl
    {
        #region *** Constants ***

        // Keep only a maximum MAX_VALUE_COUNT amount of values; This will allow
        //private const int MAX_VALUE_COUNT = 512;
        // Draw a background grid with a fixed line spacing
        private const int GRID_SPACING = 16;
        private const int MAX_PEN = 4;
        #endregion


        #region *** Member Variables ***

        // Horizontal value space in Pixels
        private int valueSpacing = 1;
        // The currently highest displayed value, required for Relative Scale Mode
        // Border Style
        private Border3DStyle b3dstyle = Border3DStyle.Sunken;

        #endregion


        #region *** Constructors ***

        public RealtimeChart()
        {
            InitializeComponent();

            // Initialize Variables

            mainChart.ChartSize = 5000;

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
        public ChartStyle ChartStyle
        {
            get { return mainChart.ChartStyle; }
            set { mainChart.ChartStyle = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Category("Appearance"), Description("Appearance and Style")]
        public PenStyle[] PenStyles
        {
            get
            {
                return mainChart.PenStyles;
            }
            set
            {
                mainChart.PenStyles = value;
            }
        }

        [DefaultValue(typeof(Border3DStyle), "Sunken"), Description("BorderStyle"), Category("Appearance")]
        new public Border3DStyle BorderStyle
        {
            get
            {
                return b3dstyle;
            }
            set
            {
                b3dstyle = value;
                Invalidate();
            }
        }

        public TimerMode TimerMode
        {
            get { return mainChart.TimerMode; }
            set { mainChart.TimerMode = value; }
        }

        public int TimerInterval
        {
            get { return mainChart.TimerInterval; }
            set { mainChart.TimerInterval = value; }
        }

        public int ChartSize
        {
            get { return mainChart.ChartSize; }
            set { mainChart.ChartSize = value; }
        }

        // Amount of currently visible values (calculated from control width and value spacing)
        public int VisibleValues { get; set; } = 0;

        #endregion


        #region *** Public Methods ***

        /// <summary>
        /// Clears the whole chart
        /// </summary>
        public void Clear()
        {
            mainChart.Clear();
        }

        /// <summary>
        /// Adds a value to the Chart Line
        /// </summary>
        /// <param name="value">progress value</param>
        public void AddValue(DataSample values)
        {
            mainChart.AddValue(values);
        }

        #endregion


        #region *** Private Methods: Common ***


        #endregion


        #region *** Overrides ***

        /// Override OnPaint method
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    // Enable AntiAliasing, if needed
        //    //if (perfChartStyle.AntiAliasing)
        //    //    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        //    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
        //    DrawBackgroundAndGrid(e.Graphics);
        //    DrawChart(e.Graphics);
        //}

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Invalidate();
        }

        #endregion


        #region *** Event Handlers ***

        private void colorSet_ColorSetChanged(object sender, EventArgs e)
        {
            //Refresh Chart on Resize
            Invalidate();
        }

        #endregion

    }

}
