using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorApp
{
    internal class ColorInfo
    {
       
            // Private variables
            private int red;
            private int green;
            private int blue;

            // Properties with getters and setters
            public int Red
            {
                get { return red; }
                set { red = Math.Min(Math.Max(value, 0), 255); } // restrict 0-255
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

            // Constructor
            public ColorInfo(int r, int g, int b)
            {
                Red = r;
                Green = g;
                Blue = b;
            }

            // Method to get Hex code
            public string GetHexCode()
            {
                return $"#{Red:X2}{Green:X2}{Blue:X2}";
            }

            // Polymorphism example: Overloaded method
            public string GetHexCode(bool includeHash)
            {
                return includeHash ? $"#{Red:X2}{Green:X2}{Blue:X2}" : $"{Red:X2}{Green:X2}{Blue:X2}";
            }

            // Display info
            public override string ToString()
            {
                return $"RGB({Red}, {Green}, {Blue}) - Hex: {GetHexCode()}";
            }
        

    }
}
