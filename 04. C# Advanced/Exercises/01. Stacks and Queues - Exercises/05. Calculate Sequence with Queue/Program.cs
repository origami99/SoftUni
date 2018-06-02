using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Queue<long> sequence = new Queue<long>();
        long s = n;
        sequence.Enqueue(s);

        for (int i = 0, skipCount = 0; i < 49; i++)
        {
            switch (i % 3)
            {
                case 0:
                    s = sequence.ToArray().Skip(skipCount).Take(1).ToArray()[0];
                    sequence.Enqueue(s + 1);
                    skipCount++;
                    break;
                case 1:
                    sequence.Enqueue((2 * s + 1));
                    break;
                case 2:
                    sequence.Enqueue(s + 2);
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", sequence));
    }
}
