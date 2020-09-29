using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realtimeChart
{
    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    public class ChartStyle
    {
        private ChartPen verticalGridPen;
        private ChartPen horizontalGridPen;

        private Color backgroundColorTop = Color.DarkGreen;
        private Color backgroundColorBottom = Color.DarkGreen;

        private bool showVerticalGridLines = true;
        private bool showHorizontalGridLines = true;
        private bool antiAliasing = false;

        public ChartStyle()
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
}
