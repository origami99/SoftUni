using System;

class CathTheThief
{
    static void Main()
    {
        string type = Console.ReadLine();
        byte n = byte.Parse(Console.ReadLine());

        long maxID = 0;

        switch (type)
        {
            case "sbyte":
                maxID = sbyte.MinValue;

                for (byte i = 0; i < n; i++)
                {
                    long id = long.Parse(Console.ReadLine());

                    if (id >= maxID && id <= sbyte.MaxValue)
                    {
                        maxID = id;
                    }
                }
                break;
            case "int":
                maxID = int.MinValue;

                for (byte i = 0; i < n; i++)
                {
                    long id = long.Parse(Console.ReadLine());

                    if (id >= maxID && id <= int.MaxValue)
                    {
                        maxID = id;
                    }
                }
                break;
            case "long":
                maxID = long.MinValue;

                for (byte i = 0; i < n; i++)
                {
                    long id = long.Parse(Console.ReadLine());

                    if (id >= maxID)
                    {
                        maxID = id;
                    }
                }
                break;
        }

        Console.WriteLine(maxID);
    }
}
