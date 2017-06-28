using System;
using System.Text.RegularExpressions;
using System.Linq;
class MatchFullName
{
    static void Main()
    {
       MatchCollection names = Regex
            .Matches(Console.ReadLine(), @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

        foreach (var name in names)
        {
            Console.Write($"{name} ");
        }
        Console.WriteLine();
    }
}
