using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        String str = Console.ReadLine();

        Console.WriteLine("Length: " + str.Length);
        Console.WriteLine("Uppercase: " + str.ToUpper());

        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine($"Reverse: {new String(arr)}");
    }
}
