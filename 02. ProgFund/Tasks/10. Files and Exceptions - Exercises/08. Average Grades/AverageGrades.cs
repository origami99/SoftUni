using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public double[] Grades { get; set; }

    public double Average
    {
        get { return Grades.Average(); }
    }
}

class AverageGrades
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            string name = input.First();
            double[] grades = input.Skip(1).Select(double.Parse).ToArray();

            students.Add(new Student { Name = name, Grades = grades });
        }

        students = students
            .OrderBy(x => x.Name)
            .ThenByDescending(x => x.Average)
            .ToList();

        foreach (var stud in students)
        {
            if (stud.Average >= 5.00)
            {
                Console.WriteLine($"{stud.Name} -> {stud.Average:F2}");
            }
        }
    }
}
