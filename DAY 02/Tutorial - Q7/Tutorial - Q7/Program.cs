using System;

enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Days today = Days.Wednesday;

        Console.WriteLine("Today is: " + today);
    }
}