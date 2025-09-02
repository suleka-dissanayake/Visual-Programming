using System;

interface Shape
{
    void Draw();
}

class Circle : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle...");
    }
}

class Square : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square...");
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle();
        circle.Draw();

        Shape square = new Square();
        square.Draw();
    }
}
