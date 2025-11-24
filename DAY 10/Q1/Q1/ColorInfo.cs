using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class ColorInfo
    {
        private int red;
        private int green;
        private int blue;

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

        public ColorInfo(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public string GetHexCode()
        {
            return $"#{Red:X2} {Green:X2} {Blue:X2}";
        }

        public string GetHexCode(bool includeHash)
        {
            return includeHash ? $"#{Red:X2} {Green:X2} {Blue:X2}" : $"{Red:X2} {Green:X2} {Blue:X2}";
        }

        public override string ToString()
        {
            return $"RGB({Red},{Green},{Blue} - Hex: {GetHexCode()})";
        }
    }
}
