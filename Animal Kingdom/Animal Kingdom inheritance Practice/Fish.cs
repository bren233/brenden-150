using System;

public class Fish : Animal
{
    public Fish(string name, int age) : base(name, age)
    {
    }

    public override void makeSound()
    {
        Console.WriteLine($"{Name} bubbles.");
    }
}