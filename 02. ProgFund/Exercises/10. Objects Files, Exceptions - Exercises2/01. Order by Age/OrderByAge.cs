using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
}

class OrderByAge
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<Person> dudes = new List<Person>();

        while (input != "End")
        {
            Person person = ReadPerson(input);

            dudes.Add(person);

            input = Console.ReadLine();
        }

        dudes = dudes.OrderBy(p => p.Age).ToList();

        foreach (Person dude in dudes)
        {
            Console.WriteLine($"{dude.Name} with ID: {dude.ID} is {dude.Age} years old.");
        }
    }

    private static Person ReadPerson(string input)
    {
        string[] personInfo = input
            .Split(' ')
            .ToArray();

        Person person = new Person()
        {
            Name = personInfo[0],
            ID = personInfo[1],
            Age = int.Parse(personInfo[2])
        };

        return person;
    }
}
