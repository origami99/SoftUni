using System;

class VariableInHexFormat
{ 
    static void Main()
    {
        string hex = Console.ReadLine();

        Console.WriteLine(Convert.ToInt32(hex, 16));
    }
}
