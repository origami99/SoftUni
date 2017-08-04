using System;

class SMSTyping
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string totalInput = "";

        for (int i = 0; i < n; i++)
        {
            int charCode = int.Parse(Console.ReadLine());

            int numberOfDigits = charCode.ToString().Length;
            int mainNumber = charCode % 10;

            int alphabetIndex = (mainNumber - 2) * 3 + numberOfDigits;
            if (mainNumber > 7)
            {
                alphabetIndex++;
            }

            char asciiIndex = (char)(alphabetIndex + 96);
            if (mainNumber == 0)
            {
                asciiIndex = ' ';
            }

            totalInput = totalInput + asciiIndex;
        }

        Console.WriteLine(totalInput);
    }
}
