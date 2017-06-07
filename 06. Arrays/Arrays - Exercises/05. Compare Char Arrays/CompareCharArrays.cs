using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        char[] arr1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
        char[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

        int minArrLenght = Math.Min(arr1.Length, arr2.Length);

        for (int i = 0; i < minArrLenght; i++)
        {
            if (arr1[i] > arr2[i])
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
                return;
            }
            else if (arr1[i] < arr2[i])
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
                return;
            }
        }

        if (arr1.Length >= arr2.Length)
        {
            Console.WriteLine(string.Join("", arr2));
            Console.WriteLine(string.Join("", arr1));
        }
        else
        {
            Console.WriteLine(string.Join("", arr1));
            Console.WriteLine(string.Join("", arr2));
        }
    }
}
