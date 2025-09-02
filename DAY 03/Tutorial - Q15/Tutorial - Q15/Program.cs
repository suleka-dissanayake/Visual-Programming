using System;

abstract class Vehicle
{
    public abstract void Drive();
}

class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

class Bike : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Bike is riding...");
    }
}

class Program
{
    static void Main()
    {
        Vehicle car = new Car();
        car.Drive();

        Vehicle bike = new Bike();
        bike.Drive();
    }
}