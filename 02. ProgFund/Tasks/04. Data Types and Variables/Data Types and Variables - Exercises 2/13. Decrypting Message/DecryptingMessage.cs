using System;

class DecryptingMessage
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());

        string message = "";

        for (byte i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());

            message = message + ((char)(letter + key));
        }

        Console.WriteLine(message);
    }
}
