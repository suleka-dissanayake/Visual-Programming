using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q10
{
    internal class Car
    {
        private String brand;
        private String model;

        Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public void Print()
        {
            Console.WriteLine($"Car Brand: {brand}\nCar Model: {model}");
        }

        static void Main(string[] args)
        {
            Car c1 = new Car("Posche","Allison");
            c1.Print();
        }
    }
}
