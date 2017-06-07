using System;

class LargestCommonEnd
{
    static void Main()
    {
        string[] arr1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int minLenght = Math.Min(arr1.Length, arr2.Length);

        int leftCombo = CalculateLeftCombo(arr1, arr2, minLenght);
        int rightCombo = CalculateRightCombo(arr1, arr2, minLenght);

        int maxCombo = Math.Max(leftCombo, rightCombo);
        Console.WriteLine(maxCombo);
    }

    public static int CalculateLeftCombo(string[] arr1, string[] arr2, int minLenght)
    {
        int countLeftCombo = 0;

        for (int i = 0; i < minLenght; i++)
        {
            if (arr1[i] == arr2[i])
            {
                countLeftCombo++;
            }
        }

        return countLeftCombo;
    }


    public static int CalculateRightCombo(string[] arr1, string[] arr2, int minLenght)
    {
        int countRightCombo = 0;

        for (int i = 0; i < minLenght; i++)
        {
            if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
            {
                countRightCombo++;
            }
        }

        return countRightCombo;
    }
}
