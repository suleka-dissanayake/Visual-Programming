using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q13
{
    internal class Rectangle: Shape
    {
        public double w;
        public double h;

        public Rectangle(double w, double h)
        {
            this.w = w;
            this.h = h;
        }

        public override double Area() 
        { 
            return w * h;
        }
    }
}
