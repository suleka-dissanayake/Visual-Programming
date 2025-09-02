using System;

class Car
{
    String brand, model;

    // Destructor
    ~Car()
    {

    }
    public Car(String brand, String model)
    {
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
        Car myCar = new Car("Toyota", "Raize");
        myCar.details();
    }
}