using System;

class BalancedBrackets
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string lastBracket = "";
        string balance = "BALANCED";

        for (int i = 0; i < n; i++)
        {
            string currentStr = Console.ReadLine();
            if (currentStr == "(")
            {
                if (lastBracket == "(")
                {
                    balance = "UNBALANCED";
                    break;
                }
                lastBracket = "(";
            }
            if (currentStr == ")")
            {
                if (lastBracket != "(")
                {
                    balance = "UNBALANCED";
                    break;
                }
                lastBracket = ")";
            }
        }
        if (lastBracket == "(")
        {
            balance = "UNBALANCED";
        }

        Console.WriteLine(balance);
    }
}
