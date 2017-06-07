using System;

class DNASequences
{
    static void Main()
    {
        int wantedSum = int.Parse(Console.ReadLine());

        string dnaElems = "ACGT";
        int[] dnaValues = { 1, 2, 3, 4 };

        for (int i1 = 0; i1 <= 3; i1++)
        {
            for (int i2 = 0; i2 <= 3; i2++)
            {
                for (int i3 = 0; i3 <= 3; i3++)
                {
                    if (dnaValues[i1] + dnaValues[i2] + dnaValues[i3] >= wantedSum)
                    {
                        Console.Write($"O{dnaElems[i1]}{dnaElems[i2]}{dnaElems[i3]}O ");
                    }
                    else
                    {
                        Console.Write($"X{dnaElems[i1]}{dnaElems[i2]}{dnaElems[i3]}X ");
                    }

                    if (i3 == 3)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
