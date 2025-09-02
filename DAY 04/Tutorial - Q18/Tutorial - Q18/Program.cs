using System;

class Program
{
    static int square(int x) => x * x;

    static void Main()
    {
        Console.Write("Enter number: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Squared value is " + square(x));
    }
}
