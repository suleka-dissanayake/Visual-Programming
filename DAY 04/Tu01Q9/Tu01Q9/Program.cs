using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q9
{
    sealed class Vehicle
    {
        public void Show()
        {
            Console.WriteLine("This is a sealed class Vehicle");
        }
    }

    //Trying to inherit will cause an error.
    // class Car: Vehicle // Can't derive from sealed class

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Show();
        }
    }
}
