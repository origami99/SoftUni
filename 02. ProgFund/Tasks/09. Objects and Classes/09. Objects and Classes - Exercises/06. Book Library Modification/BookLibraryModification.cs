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

class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Library library = new Library();
        library.Books = new List<Book>();
        Dictionary<string, DateTime> titles = new Dictionary<string, DateTime>();
        for (int i = 0; i < n; i++)
        {
            Book book = ReadBook();
            library.Books.Add(book);
            titles[book.Title] = book.ReleaseDate;
        }

        DateTime givenDate = DateTime.ParseExact(
            Console.ReadLine(),
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture);

        titles = titles
            .Where(b => b.Value > givenDate)
            .OrderBy(b => b.Value)
            .ThenBy(b => b.Key)
            .ToDictionary(a => a.Key, p => p.Value);

        foreach (var a in titles)
        {
            Console.WriteLine($"{a.Key} -> {string.Format("{0:dd.MM.yyyy}" ,a.Value)}");
        }
    }

    private static Book ReadBook()
    {
        string[] input = Console.ReadLine()
            .Split(' ')
            .ToArray();

        Book book = new Book();

        book.Title = input[0];
        book.Author = input[1];
        book.Publisher = input[2];
        book.ReleaseDate = DateTime.ParseExact(
            input[3],
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture);
        book.ISBN = input[4];
        book.Price = double.Parse(input[5]);

        return book;
    }
}
