using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = a / b;
                Console.WriteLine("Result: "+result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
        }
    }
}
