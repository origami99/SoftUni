using System;

class VaporStore
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        string game = "";

        double startBalance = balance;
        string[] games =
        {
            "OutFall 4",
            "CS: OG",
            "Zplinter Zell",
            "Honored 2",
            "RoverWatch",
            "RoverWatch Origins Edition"
        };

        double[] prices = { 39.99, 15.99, 19.99, 59.99, 29.99, 39.99 };

        while (true)
        {
            game = Console.ReadLine();

            if (game == "Game Time")
            {
                break;
            }

            switch (game)
            {
                case "OutFall 4":
                    if (balance - prices[0] >= 0)
                    {
                        balance -= prices[0];
                        Console.WriteLine($"Bought {games[0]}");
                    }
                    else if (balance - prices[0] < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "CS: OG":
                    if (balance - prices[1] >= 0)
                    {
                        balance -= prices[1];
                        Console.WriteLine($"Bought {games[1]}");
                    }
                    else if (balance - prices[1] < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "Zplinter Zell":
                    if (balance - prices[2] >= 0)
                    {
                        balance -= prices[2];
                        Console.WriteLine($"Bought {games[2]}");
                    }
                    else if (balance - prices[2] < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "Honored 2":
                    if (balance - prices[3] >= 0)
                    {
                        balance -= prices[3];
                        Console.WriteLine($"Bought {games[3]}");
                    }
                    else if (balance - prices[3] < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "RoverWatch":
                    if (balance - prices[4] >= 0)
                    {
                        balance -= prices[4];
                        Console.WriteLine($"Bought {games[4]}");
                    }
                    else if (balance - prices[4] < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                case "RoverWatch Origins Edition":
                    if (balance - prices[5] >= 0)
                    {
                        balance -= prices[5];
                        Console.WriteLine($"Bought {games[5]}");
                    }
                    else if (balance - prices[5] < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;
                default:
                    Console.WriteLine("Not Found");
                    break;
            }

            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }

        Console.WriteLine($"Total spent: ${startBalance - balance:F2}. Remaining: ${balance:F2}");
    }
}
