using System;

class Program
{
    delegate int Operation(int a, int b);

    static int Add(int x, int y) => x + y;
    static int Multiply(int x, int y) => x * y;

    static void Execute(Operation operation, int a, int b)
    {
        Console.WriteLine($"Result is {operation(a, b)}");
    }
    static void Main()
    {
        Execute(Add, 5, 3);
        Execute(Multiply, 5, 3);
    }
}