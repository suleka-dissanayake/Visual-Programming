using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q8
{
    static class Calculator
    {
        static void Add(double n1, double n2)
        {
            Console.WriteLine("Addition: " + n1 + " + " + n2 + " = " + (n1 + n2));
        }

        static void Subtract(double n1, double n2)
        {
            Console.WriteLine("Subtraction: " + n1 + " - " + n2 + " = " + (n1 - n2));
        }
        static void Divide(double n1, double n2)
        {
            Console.WriteLine("Difference: " + n1 + " / " + n2 + " = " + (n1 / n2));
        }
        static void Multiply(double n1, double n2)
        {
            Console.WriteLine("Multiplication: " + n1 + " * " + n2 + " = " + (n1 * n2));
        }



        class Demo
        {
            static void Main(string[] args)
            {
                Calculator.Add(2.0, 3.0);
                Calculator.Subtract(8.0, 6.0);
                Calculator.Divide(20.0, 5.0);
                Calculator.Multiply(5.0, 4.0);
            }
        }
    }
}
