using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;

namespace SpPerfChart
{

    /// <summary>
    /// Scale mode for value aspect ratio
    /// </summary>
    public enum ScaleMode
    {
        /// <summary>
        /// Absolute Scale Mode: Values are scaled by Scale and Offset
        /// </summary>
        Absolute,
        /// <summary>
        /// Relative Scale Mode: All values are allowed and displayed with 10% upper and lower bound
        /// </summary>
        Relative
    }

    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    public class PerfChartStyle
    {
        private ChartPen verticalGridPen;
        private ChartPen horizontalGridPen;

        private Color backgroundColorTop = Color.DarkGreen;
        private Color backgroundColorBottom = Color.DarkGreen;

        private bool showVerticalGridLines = true;
        private bool showHorizontalGridLines = true;
        private bool antiAliasing = false;

        public PerfChartStyle()
        {
            verticalGridPen = new ChartPen();
            horizontalGridPen = new ChartPen();
        }

        public bool ShowVerticalGridLines
        {
            get { return showVerticalGridLines; }
            set { showVerticalGridLines = value; }
        }

        public bool ShowHorizontalGridLines
        {
            get { return showHorizontalGridLines; }
            set { showHorizontalGridLines = value; }
        }

        public ChartPen VerticalGridPen
        {
            get { return verticalGridPen; }
            set { verticalGridPen = value; }
        }

        public ChartPen HorizontalGridPen
        {
            get { return horizontalGridPen; }
            set { horizontalGridPen = value; }
        }

        public bool AntiAliasing
        {
            get { return antiAliasing; }
            set { antiAliasing = value; }
        }

        public Color BackgroundColorTop
        {
            get { return backgroundColorTop; }
            set { backgroundColorTop = value; }
        }

        public Color BackgroundColorBottom
        {
            get { return backgroundColorBottom; }
            set { backgroundColorBottom = value; }
        }
    }

    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    public class PerfChartPenStyle
    {
        public PerfChartPenStyle() {
            AvgLinePen = new ChartPen();
            ChartLinePen = new ChartPen();
            currentMaxValue = 0;
            currentMinValue = 0;
        }

        public bool ShowAverageLine { get; set; } = true;

        public ChartPen AvgLinePen { get; set; }

        public ChartPen ChartLinePen { get; set; }

        public bool ShowPen { get; set; } = true;

        public Double Scale { get; set; } = 1.0;

        public Double Offset { get; set; } = 0.0;

        public ScaleMode ScaleMode { get; set; } 

        internal Int32 currentMaxValue;

        internal Int32 currentMinValue;
    }

    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    public class ChartPen
    {
        private Pen pen;

        public ChartPen() {
            pen = new Pen(Color.Black);
        }

        public Color Color {
            get { return pen.Color; }
            set { pen.Color = value; }
        }

        public System.Drawing.Drawing2D.DashStyle DashStyle {
            get { return pen.DashStyle; }
            set { pen.DashStyle = value; }
        }

        public float Width {
            get { return pen.Width; }
            set { pen.Width = value; }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Pen Pen {
            get { return pen; }
        }
    }
}
