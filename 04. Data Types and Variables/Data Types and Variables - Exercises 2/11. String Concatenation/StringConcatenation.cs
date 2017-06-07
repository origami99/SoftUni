using System;

class StringConcatenation
{
    static void Main()
    {
        char delimiter = char.Parse(Console.ReadLine());
        string positionType = Console.ReadLine(); // Even or odd
        byte n = byte.Parse(Console.ReadLine());

        string result = "";

        for (byte i = 1; i <= n; i++)
        {
            string word = Console.ReadLine();

            if (positionType == "even")
            {
                if (i % 2 == 0)
                {
                    result = result + word + delimiter;
                }
            }
            else if (positionType == "odd")
            {
                if (i % 2 != 0)
                {
                    result = result + word + delimiter;
                }
            }
        }

        result = result.TrimEnd(delimiter);
        //         ↓ This will work also ↓
        //result = result.Remove(result.Length - 1, 1);

        Console.WriteLine(result);
    }
}
