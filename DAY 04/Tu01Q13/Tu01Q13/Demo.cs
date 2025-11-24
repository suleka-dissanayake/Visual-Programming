using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q13
{
    internal class Demo
    {
        public static void Main(String[] args)
        {
            Shape a1 = new Circle(7);
            Console.WriteLine("Area of the Circle is " + a1.Area());

            Shape a2 = new Rectangle(5, 8);
            Console.WriteLine("Area of the Rectangle is " + a2.Area());
        }
    }
}
