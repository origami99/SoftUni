using System;
using System.Globalization;
using System.Linq;

class ByteFlip
{
    static void Main()
    {
        string[] bytes = Console.ReadLine()
            .Split(' ')
            .ToArray();

        bytes = GetSpecificLengthBytes(bytes, 2);

        ReverseEveryByte(bytes);

        bytes = ReverseArray(bytes);

        bytes = ConverFromHexToChar(bytes);

        PrintResult(bytes);
    }

    private static string[] GetSpecificLengthBytes(string[] bytes, int length)
    {
        bytes = bytes
            .Where(x => x.Length == length)
            .ToArray();

        return bytes;
    }

    private static void ReverseEveryByte(string[] bytes)
    {
        for (int i = 0; i < bytes.Length; i++)
        {
            bytes[i] = new string(bytes[i].Reverse().ToArray());
        }
    }

    private static string[] ReverseArray(string[] bytes)
    {
        return bytes.Reverse().ToArray();
    }

    private static string[] ConverFromHexToChar(string[] bytes)
    {
        for (int i = 0; i < bytes.Length; i++)
        {
            bytes[i] = int.Parse(bytes[i], NumberStyles.HexNumber).ToString();
        }
        bytes = bytes.Select(x => ((char)(int.Parse(x))).ToString()).ToArray();

        return bytes;
    }

    private static void PrintResult(string[] bytes)
    {
        Console.WriteLine(string.Join("", bytes));
    }
}
