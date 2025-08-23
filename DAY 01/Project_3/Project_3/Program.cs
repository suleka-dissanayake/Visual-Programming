using System;

class Project_3
{
    public static void Main()
    {
        int radius, length, width;
        Console.Write("Enter Radius: ");
        radius = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter length of a rectangle: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter width: ");
        width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Perimeter of the circle is " + radius * 2 * 22/7);
        Console.WriteLine("Area of the circle is " + 22/7 * radius * radius);
        Console.WriteLine();
        Console.WriteLine("Perimeter of the rectangle is " + 2 * (length + width));
        Console.WriteLine("Area of the rectangle is " + length * width);
    }
}