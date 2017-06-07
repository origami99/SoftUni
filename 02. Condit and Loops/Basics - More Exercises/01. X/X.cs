using System;

class X
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            string topMiddleSpaces = new string(' ', n - 2 - i * 2);
            string topEdgeSpaces = new string(' ', i);
            Console.WriteLine("{0}x{1}x{0}", topEdgeSpaces, topMiddleSpaces);
        }

        string middleSpaces = new string(' ', n / 2);
        Console.WriteLine("{0}x{0}", middleSpaces);

        for (int i = 0; i < n / 2; i++)
        {
            string lowMiddleSpaces = new string(' ', i * 2 + 1);
            string lowEdgeSpaces = new string(' ', n / 2 - i - 1);
            Console.WriteLine("{0}x{1}x{0}", lowEdgeSpaces, lowMiddleSpaces);
        }

        // 5

        // x   x
        //  x x
        //   x
        //  x x
        // x   x
    }
}
