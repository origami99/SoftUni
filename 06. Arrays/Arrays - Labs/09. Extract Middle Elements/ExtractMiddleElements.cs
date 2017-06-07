using System;
using System.Linq;

class ExtractMiddleElements
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (arr.Length == 1)
        {
            Console.WriteLine($"{{ {arr[0]} }}");
        }

        else if (arr.Length % 2 == 0)
        {
            Console.WriteLine("{{ {0}, {1} }}",
                arr[arr.Length / 2 - 1],
                arr[arr.Length / 2]);
        }

        else if (arr.Length % 2 != 0)
        {
            Console.WriteLine("{{ {0}, {1}, {2} }}",
                arr[arr.Length / 2 - 1],
                arr[arr.Length / 2],
                arr[arr.Length / 2 + 1]);
        }
    }
}
