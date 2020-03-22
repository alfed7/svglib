using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvgLib
{
    public class SvgDistance
    {
        public double Width { get; set; }
        public string Unit { get; set; }

        public override string ToString()
            => string.Format(CultureInfo.InvariantCulture, "{0}{1}", Width, Unit);
    }
}
