using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realtimeChart
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

}
