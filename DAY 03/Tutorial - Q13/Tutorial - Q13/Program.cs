using System;

class Shape
{
    public virtual double Area()
    {
        return 0.0;
    }
}

class Circle : Shape
{
    double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return 22.0 / 7 * radius * radius;
    }
}

class Rectangle : Shape
{
    double length, width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Shape c1 = new Circle(14.0);
        Console.WriteLine($"Area of Circle is {c1.Area()}");

        Shape r1 = new Rectangle(10.0, 20.0);
        Console.WriteLine($"Area of Rectangle is {r1.Area()}");
    }
}
