using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks.");
    }
}

class Dog: Animal
{
     public override void Speak()
     {
         Console.WriteLine("Dog barks.");
     }
}

class Cat: Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Demo
{
    static void Main(string[] args)
    {
        Animal a = new Animal();
        a.Speak();

        Animal b = new Dog();
        b.Speak();

        Animal c = new Cat();
        c.Speak();

    }
}

