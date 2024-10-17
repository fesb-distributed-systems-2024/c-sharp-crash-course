using Interfaces;

namespace Interfaces;

// Interface example is a similar to the
// Inheritance example, the only difference
// is that an "interface" cannot have a function implementation
// while a "class" that is inherited from, can.

// Any class that implements this interface "ICanMakeSound"
// *MUST implement the function "public void MakeSound()"
// That's it.
interface ICanMakeSound
{
    public void MakeSound();
}

class Dog : ICanMakeSound
{
    public string Name { get; set; }
    public Dog(string name)
    {
        this.Name = name;
    }

    // Since we inherit from ICanMakeSound, we *MUST implement this method
    public void MakeSound()
    {
        Console.WriteLine("Woof, woof!");
    }
}

class Cat : ICanMakeSound
{
    public string Name { get; set; }
    public Cat(string name)
    {
        this.Name = name;
    }

    // Since we inherit from ICanMakeSound, we *MUST implement this method
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Motorcycle : ICanMakeSound
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public Motorcycle(string brand, string model)
    {
        this.Brand = brand;
        this.Model = model;
    }

    // Since we inherit from ICanMakeSound, we *MUST implement this method
    public void MakeSound()
    {
        Console.WriteLine("Vroom, vroom.");
    }
}

class Bell : ICanMakeSound
{
    public string Color { get; set; }
    public Bell(string color)
    {
        this.Color = color;
    }

    // Since we inherit from ICanMakeSound, we *MUST implement this method
    public void MakeSound()
    {
        Console.WriteLine("Ding, ding");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICanMakeSound[] soundables = new ICanMakeSound[]{
            new Dog("Kiara"),
            new Cat("Spiky"),
            new Motorcycle("BMW", "R 1250 RS"),
            new Motorcycle("Kawasaki", "Ninja ZX 6R"),
            new Bell("Yellow")
        };

        foreach (var item in soundables)
        {
            item.MakeSound();
        }
    }
}