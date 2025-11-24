using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q15
{
    public class Car : Vehicle
    {
        override
        public void Drive()
        {
            Console.WriteLine("Car drives");
        }
    }
}
