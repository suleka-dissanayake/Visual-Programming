using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle c = new Car();
            c.Drive();
            Vehicle b = new Bike();
            b.Drive();
        }
    }
}
