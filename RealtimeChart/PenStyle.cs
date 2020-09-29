using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realtimeChart
{
    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    public class PenStyle
    {
        public PenStyle()
        {
            ChartLinePen = new ChartPen();
        }

        public bool ShowAverageLine { get; set; } = true;

        public ChartPen ChartLinePen { get; set; }

        public bool ShowPen { get; set; } = true;

        public Double Scale { get; set; } = 1.0;

        public Double Offset { get; set; } = 0.0;

        public ScaleMode ScaleMode { get; set; }

    }
}
