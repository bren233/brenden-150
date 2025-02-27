using Newtonsoft.Json;
using System;

class program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Billy Bob",
            Age = 23
        };

        string json = JsonConvert.SerializeObject(person);
        Console.WriteLine("Serilized JSON " + json);

        Person deserializePerson = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine("Desialized Person Name " + deserializePerson.Name + " Age - " + deserializePerson.Age);

    }
}