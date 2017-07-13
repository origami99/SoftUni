using System;

class ReverseArrayOfIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = n - 1; i >= 0; i--)
        {
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }

        PrintArr(numbers);
    }

    public static void PrintArr(int[] numbers)
    {
        foreach (var item in numbers)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
    }
}
