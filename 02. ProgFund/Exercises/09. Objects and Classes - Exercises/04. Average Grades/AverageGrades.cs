using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverageGrade { get { return Grades.Average(); } }
}

class AverageGrades
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();
        for (int i = 0; i < n; i++)
        {
            Student currentStudent = ReadStudent();
            students.Add(currentStudent);
        }

        students = students
            .OrderBy(s => s.Name)
            .ThenByDescending(s => s.AverageGrade)
            .ToList();

        foreach (Student s in students)
        {
            if (s.AverageGrade >= 5)
            {
                Console.WriteLine($"{s.Name} -> {s.AverageGrade:F2}");
            }
        }
    }

    private static Student ReadStudent()
    {
        string[] studentData = Console.ReadLine()
            .Split(' ')
            .ToArray();

        Student student = new Student();

        student.Name = studentData[0];
        student.Grades = studentData
            .Skip(1)
            .Select(double.Parse)
            .ToList();

        return student;
    }
}
