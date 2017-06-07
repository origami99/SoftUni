using System;

class BalancedBrackets
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        byte openBracketsCount = 0;
        byte closedBracketsCount = 0;

        for (int i = 0; i < n; i++)
        {
            string text = Console.ReadLine();

            if (text == "(")
            {
                openBracketsCount++;
            }
            else if (text == ")")
            {
                closedBracketsCount++;

                if (openBracketsCount == 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
        }

        if (openBracketsCount == closedBracketsCount)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}
