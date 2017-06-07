using System;
using System.Linq;

class ReverseArrayOfStrings_v2
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(' ').ToArray();
        var reversedArr = arr.Reverse();
        Console.WriteLine(string.Join(" ", reversedArr));
    }
}
