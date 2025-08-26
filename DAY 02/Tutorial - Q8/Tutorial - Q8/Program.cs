using System;

public static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return (double)a / b;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Choose operation: (+,-,*,/) --> ");
        string operation = Console.ReadLine();

        try
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Sum: {Calculator.Add(a, b)}");
                    break;
                case "-":
                    Console.WriteLine($"Difference: {Calculator.Subtract(a, b)}");
                    break;
                case "*":
                    Console.WriteLine($"Product: {Calculator.Multiply(a, b)}");
                    break;
                case "/":
                    Console.WriteLine($"Quotient: {Calculator.Divide(a, b)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}