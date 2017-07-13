using System;
using System.IO;
using System.Linq;

class LineNumbers
{
    static void Main()
    {
        string[] text = File.ReadAllLines("lines.txt")
            .Select((line, index) => $"{index + 1}. {line}")
            .ToArray();

        Console.WriteLine(string.Join("\r\n", text));
    }
}
