using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Rectangle
{
    double width, height;

    public double Area
    {
        return (width* height);
    }


    class Demo
    {
        static void Main(string[] args)
        {
            Rectangle r;
            Console.Write("Enter length: ");
            r.length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            r.width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area = "+ r.Area());
    }
}
