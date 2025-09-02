using System;

class Vehicle
{
    private int chassyNo;

    public Vehicle(int chassyNo)
    {
        this.chassyNo = chassyNo;
    }

    public void Drive()
    {
        Console.WriteLine("driving");
    }
}

class Car : Vehicle
{
    int door;
    String brand, model;
    public Car(int chassyNo, int door, String brand, String model) : base(chassyNo)
    {
        this.door = door;
        this.brand = brand;
        this.model = model;
    }

    public void details()
    {
        Console.WriteLine($"Brand: {brand}, Model: {model}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car(12345, 4, "Toyota", "Raize");
        myCar.details();
        myCar.Drive();
    }
}