using System;
using System.Linq;

class ReverseArrayOfStrings
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(' ').ToArray();

        for (int i = 0; i < arr.Length / 2; i++)
        {
            var temp = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = arr[i];
            arr[i] = temp;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
