using System;
using System.IO;
using System.Linq;

class OddLines
{
    static void Main()
    {
        var text = File.ReadAllLines("lines.txt")
            .Where((x, i) => i % 2 != 0);

        Console.WriteLine(string.Join("\r\n", text));
    }
}
