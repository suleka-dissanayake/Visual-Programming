using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int w, h;

        Console.Write("Enter height: ");
        h = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter width: ");
        w = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Area = "+(w*h));
        Console.WriteLine("Perimeter = " + (2*(h+w)));
    }
}

