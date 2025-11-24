using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q13
{
    internal class Circle: Shape
    {
        public double r;

        public Circle(double r)
        {
            this.r = r; 
        } 
        public override double Area()
        {
            return Math.PI * r * r;
        }
    }
}
