// Question 01
using System;

class Q1
{
    static void Main()
    {
        // Input two numbers
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform operations
        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient =  num1 / num2

        // Display results
        Console.WriteLine($"\nSum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Multiplication: {product}");
        Console.WriteLine($"Division: {quotient}");
    }
}