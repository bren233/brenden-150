using System;


class Program
{
    static void Main(string[] args)
    {
        Bird parrot = new Bird("Parrot", 5);
        Fish goldfish = new Fish("Goldfish", 1);

        
        parrot.makeSound(); 
        goldfish.makeSound(); 

       
        Console.WriteLine(parrot.Name); 
        Console.WriteLine(goldfish.Age); 
    }
}
