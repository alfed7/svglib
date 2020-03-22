using System;
using System.ComponentModel;
using System.Globalization;

namespace SvgLib
{
    public struct SvgViewBox
    {
        public SvgViewBox(string attrText)
        {
            var items = attrText.Split(' ');
            Left = double.Parse(items[0]);
            Top = double.Parse(items[1]);
            Width = double.Parse(items[2]);
            Height = double.Parse(items[3]);
        }

        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public override string ToString()
            => string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3}", Left, Top, Width, Height);
    }
}
