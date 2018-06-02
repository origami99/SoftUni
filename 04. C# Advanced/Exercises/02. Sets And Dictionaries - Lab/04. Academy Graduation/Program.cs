using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedDictionary<string, double> students = new SortedDictionary<string, double>();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double score = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .Average();

            students.Add(name, score);
        }

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} is graduated with {student.Value}");
        }
    }
}
