using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of the day (1–7): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int day))
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("You selected Monday");
                    break;
                case 2:
                    Console.WriteLine("You selected Tuesday");
                    break;
                case 3:
                    Console.WriteLine("You selected Wednesday");
                    break;
                case 4:
                    Console.WriteLine("You selected Thursday");
                    break;
                case 5:
                    Console.WriteLine("You selected Friday");
                    break;
                case 6:
                    Console.WriteLine("You selected Saturday");
                    break;
                case 7:
                    Console.WriteLine("You selected Sunday");
                    break;
                default:
                    Console.WriteLine("Error: Please enter a number between 1 and 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
        }
    }
}