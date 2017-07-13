using System;
using System.IO;
using System.Linq;

class MergeFiles
{
    static void Main()
    {
        int[] file1 = File.ReadAllLines("input1.txt")
            .Select(int.Parse)
            .ToArray();
        int[] file2 = File.ReadAllLines("input2.txt")
            .Select(int.Parse)
            .ToArray();

        string[] concated = file1.Concat(file2)
            .OrderBy(number => number)
            .Select(x => Convert.ToString(x))
            .ToArray();

        File.Create("output.txt").Close();

        File.AppendAllLines("output.txt", concated);
    }
}
