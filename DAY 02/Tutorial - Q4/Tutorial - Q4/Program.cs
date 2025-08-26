using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        double total = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter mark: ");
            string input = Console.ReadLine();
            arr[i] = int.Parse(input);
            total += arr[i];
        }

        double average = total / arr.Length;

        Console.WriteLine("\nMarks entered:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Mark {i + 1}: {arr[i]}");
        }
        Console.WriteLine($"Average is {average}");
    }
}