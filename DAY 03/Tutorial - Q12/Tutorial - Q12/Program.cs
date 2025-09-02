using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sounds...");
    }
    
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog Barks...");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat Meows...");
    }
}

class Program
{
    static void Main()
    {
        Dog mydog = new Dog();
        mydog.Speak();

        Cat mycat = new Cat();
        mycat.Speak();
    }
}