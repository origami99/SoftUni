using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
    public string Name { get; set; }
    public Dictionary<string, double> ShopList { get; set; }
    public double Bill { get; set; }
}

class Program
{
    static void Main()
    {
        int numberOfItems = int.Parse(Console.ReadLine());

        Dictionary<string, double> menu = new Dictionary<string, double>();
        for (int i = 0; i < numberOfItems; i++)
        {
            string[] input = Console.ReadLine()
                .Split('-')
                .ToArray();

            menu[input[0]] = double.Parse(input[1]);
        }

        List<Customer> students = new List<Customer>();
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end of clients")
            {
                break;
            }

            string[] clientInfo = input
                .Split('-', ',')
                .ToArray();

            string name = clientInfo[0];
            string product = clientInfo[1];
            double quantity = double.Parse(clientInfo[2]);

            if (!menu.ContainsKey(product))
            {
                continue;
            }

            Customer client = new Customer();
            client.ShopList = new Dictionary<string, double>();
            client.Name = clientInfo[0];
            client.ShopList.Add(product, quantity);

            if (students.Any(c => c.Name == name))
            {
                Customer existingCustomer = students.First(c => c.Name == name);

                if (existingCustomer.ShopList.ContainsKey(product))
                {
                    existingCustomer.ShopList[product] += quantity;
                }
                else
                {
                    existingCustomer.ShopList[product] = quantity;
                }
            }
            else
            {
                students.Add(client);
            }
        }

        foreach (var s in students)
        {
            foreach (var item in s.ShopList)
            {
                foreach (var product in menu)
                {
                    if (item.Key == product.Key)
                    {
                        s.Bill += item.Value * product.Value;
                    }
                }
            }
        }

        students = students
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Bill)
            .ToList();

        foreach (var s in students)
        {
            Console.WriteLine(s.Name);

            foreach (KeyValuePair<string, double> item in s.ShopList)
            {
                Console.WriteLine($"-- {item.Key} - {item.Value}");
            }

            Console.WriteLine("Bill: {0:f2}", s.Bill);
        }

        Console.WriteLine("Total bill: {0:F2}", students.Sum(c => c.Bill));
    }
}
