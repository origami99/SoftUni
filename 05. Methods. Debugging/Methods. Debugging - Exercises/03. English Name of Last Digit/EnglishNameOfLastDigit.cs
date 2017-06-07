using System;

class EnglishNameOfLastDigit
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        num = Math.Abs(num);

        string digitWord = GetLastDigitAsWord(num);

        Console.WriteLine(digitWord);
    }

    public static string GetLastDigitAsWord(long num)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        long lastDigit = num % 10;

        return digits[lastDigit];
    }
}
