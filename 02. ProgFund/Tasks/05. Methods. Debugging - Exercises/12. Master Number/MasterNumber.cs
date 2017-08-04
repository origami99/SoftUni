using System;

class MasterNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            bool isPalindrome = GetPalindrome(i);

            bool isDividingBySeven = false;
            int sumOfDigits = GetSumOfDigits(i);
            if (sumOfDigits % 7 == 0)
            {
                isDividingBySeven = true;
            }

            bool isContainingEvenDigit = GetContainingEvenDigit(i);

            if (isPalindrome && isDividingBySeven && isContainingEvenDigit)
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool GetPalindrome(int i)
    {
        string i_Stringed = i.ToString();
        int max = i_Stringed.Length - 1;

        for (int k = 0; k < max - max / 2; k++)
        {
            if (i_Stringed[k] != i_Stringed[max - k])
            {
                return false;
            }
        }

        return true;
    }

    private static int GetSumOfDigits(int i)
    {
        int sum = 0;
        int lastDigit = 0;

        while (i > 0)
        {
            lastDigit = i % 10;
            sum += lastDigit;
            i /= 10;
        }

        return sum;
    }

    private static bool GetContainingEvenDigit(int i)
    {
        while (i > 0)
        {
            int lastDigit = i % 10;

            if (lastDigit % 2 == 0)
            {
                return true;
            }

            i /= 10;
        }

        return false;
    }
}
