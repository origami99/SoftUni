using System;
using System.Collections.Generic;

class SimpleCalculator
{
    static void Main()
    {
        string[] expression = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Stack<int> nums = new Stack<int>();

        bool isPositive = true;
        foreach (string item in expression)
        {
            switch (item)
            {
                case "-":
                    isPositive = false;
                    break;
                case "+":
                    isPositive = true;
                    break;
                default:
                    int currNum = int.Parse(item);
                    if (!isPositive) { currNum *= -1; }
                    nums.Push(currNum);
                    break;
            }
        }

        int result = 0;
        foreach (int num in nums)
        {
            result += num;
        }

        Console.WriteLine(result);
    }
}
