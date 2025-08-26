using System;

class Vehicle
{
    private int chassyNo;
    private string name;

    public Vehicle(int chassyNo, string name)
    {
        this.chassyNo = chassyNo;
        this.name = name;
    }

    public void Drive()
    {
        Console.WriteLine("driving");
    }
}

class Car : Vehicle
{
    int door;

    public Car(int chassyNo, string name, int door) : base(chassyNo, name)
    {
        this.door = door;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car(12345, "Toyota", 4);
        myCar.Drive();
    }
}