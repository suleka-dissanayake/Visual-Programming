using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 1) 
            {
                Console.WriteLine("Odd Number");
            }
            else
            {
                Console.WriteLine("Even Number");
            }
        }
    }
}
