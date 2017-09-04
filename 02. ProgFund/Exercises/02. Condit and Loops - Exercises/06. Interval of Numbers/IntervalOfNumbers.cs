using System;

class IntervalOfNumbers
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
        }

        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i);
        }
    }
}
