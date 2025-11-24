using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q11
{
    public class Car
    {
        String brand;
        String model;

        ~Car()
        {
            Console.WriteLine("Object destroyed.");
        }

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
            Car c1 = new Car("Posche", "Allison");
            c1.Print();
        }
    }
}
