using System;

public class Bird : Animal
{
    public Bird(string name, int age) : base(name,age)
        {
        }
    public override void makeSound()
    {
        Console.WriteLine($"{Name} chirps.");
    }
}
