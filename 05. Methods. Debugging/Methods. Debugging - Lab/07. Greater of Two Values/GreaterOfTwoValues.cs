using System;

class GreaterOfTwoValues
{
    static void Main()
    {
        string valueType = Console.ReadLine();

        if (valueType == "int")
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int bigger = GetBigger(a, b);
            Console.WriteLine(bigger);
        }
        else if (valueType == "char")
        {
            char a = char.Parse(Console.ReadLine());
            var b = char.Parse(Console.ReadLine());
            char bigger = GetBigger(a, b);
            Console.WriteLine(bigger);
        }
        else if (valueType == "string")
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string bigger = GetBigger(a, b);
            Console.WriteLine(bigger);
        }
    }

    public static int GetBigger(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }

        return second;
    }

    public static char GetBigger(char first, char second)
    {
        if (first >= second)
        {
            return first;
        }

        return second;
    }

    public static string GetBigger(string first, string second)
    {
        if (first.CompareTo(second) >= 0)
        {
            return first;
        }

        return second;
    }
}
