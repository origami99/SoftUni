using System;

class MaxMethod
{
    static void Main()
    {
        string name = Console.ReadLine();
        PrintGreetings(name);
    }

    public static void PrintGreetings(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
