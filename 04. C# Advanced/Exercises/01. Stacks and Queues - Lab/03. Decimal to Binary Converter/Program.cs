using System;
using System.Collections.Generic;

class DecimalToBinaryConverter
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine(0);
            return;
        }

        Stack<int> binaryStack = new Stack<int>();

        while (num != 0)
        {
            int currBit = num % 2;
            binaryStack.Push(currBit);
            num /= 2;
        }

        Console.WriteLine(string.Join("", binaryStack));
    }
}
