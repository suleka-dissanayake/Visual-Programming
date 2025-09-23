using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_info
{
    internal class Colour
    {
        private int red, green, blue;

        public Colour(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Red
        {
            get { return red; }
            set { red = Math.Min(Math.Max(value, 0), 255); }
        }

        public int Green
        {
            get { return green; }
            set { green = Math.Min(Math.Max(value, 0), 255); }
        }

        public int Blue
        {
            get { return blue; }
            set { blue = Math.Min(Math.Max(value, 0), 255); }
        }

        public string GetHexCode()
        {
            return $"#{red:X2}{green:X2}{blue:X2}";
        }

        public string GetHexCode(bool includeHash)
        {
            return includeHash ? $"#{red:X2}{green:X2}{blue:X2}" : $"{red:X2}{green:X2}{blue:X2}";
        }

        public override string ToString()
        {
            return $"RGB({Red}, {Green}, {Blue}) - Hex: {GetHexCode()}";
        }
    }
}
