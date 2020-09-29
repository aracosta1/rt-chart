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
    public class ChartPen
    {
        private Pen pen;

        public ChartPen()
        {
            pen = new Pen(Color.Black);
        }

        public Color Color
        {
            get { return pen.Color; }
            set { pen.Color = value; }
        }

        public System.Drawing.Drawing2D.DashStyle DashStyle
        {
            get { return pen.DashStyle; }
            set { pen.DashStyle = value; }
        }

        public float Width
        {
            get { return pen.Width; }
            set { pen.Width = value; }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Pen Pen
        {
            get { return pen; }
        }
    }
}
