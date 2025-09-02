using System;

class Program
{
    static void Main()
    {
        double num1, num2;

        Console.Write("Enter value for number 1: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter value for number 2: ");
        num2 = double.Parse(Console.ReadLine());

        try
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            double result = num1 / num2;
            Console.WriteLine($"Result is {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't be divided by zero!");
        }
    }
}
