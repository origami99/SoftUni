using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public List<DateTime> Dates { get; set; }
    public List<string> Comments { get; set; }
}

public class Program
{
    public static void Main()
    {
        string line = Console.ReadLine();

        SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();
        while (!line.Equals("end of dates"))
        {
            string[] studentData = line
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string studentName = studentData[0];

            List<DateTime> dates = studentData
                .Skip(1)
                .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                .ToList();

            Student currentStudent = new Student();
            currentStudent.Name = studentName;

            if (!students.ContainsKey(studentName))
            {
                students[studentName] = currentStudent;
                currentStudent.Dates = dates;
            }

            else
            {
                students[studentName].Dates.AddRange(dates);
            }

            line = Console.ReadLine();
        }

        line = Console.ReadLine();

        while (!line.Equals("end of comments"))
        {
            string[] studentComment = line.Split('-');

            string studentName = studentComment[0];
            string comment = studentComment[1];

            List<string> comments = new List<string>();
            comments.Add(comment);

            if (students.ContainsKey(studentName))
            {
                if (students[studentName].Comments != null)
                {
                    students[studentName].Comments.AddRange(comments);
                }

                else
                {
                    students[studentName].Comments = comments;
                }
            }

            line = Console.ReadLine();
        }

        foreach (var student in students)
        {
            Console.WriteLine(student.Key);
            Console.WriteLine("Comments:");

            if (student.Value.Comments != null)
            {
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
            }

            Console.WriteLine("Dates attended:");

            foreach (var date in student.Value.Dates.OrderBy(x => x))
            {
                Console.WriteLine($"-- {date:dd/MM/yyyy}");
            }
        }
    }
}
