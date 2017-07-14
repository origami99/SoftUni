using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, double> library = new Dictionary<string, double>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            Book book = new Book
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = input[4],
                Price = double.Parse(input[5])
            };

            if (library.ContainsKey(book.Author))
            {
                library[book.Author] += book.Price;
            }
            else
            {
                library[book.Author] = book.Price;
            }
        }

        library = library
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var bk in library)
        {
            Console.WriteLine($"{bk.Key} -> {bk.Value:F2}");
        }
    }
}
