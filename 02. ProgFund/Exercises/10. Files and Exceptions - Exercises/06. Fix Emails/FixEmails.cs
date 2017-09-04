using System;

class FixEmails
{
    static void Main()
    {
        while (true)
        {
            string name = Console.ReadLine();
            if (name == "stop")
            {
                return;
            }
            string email = Console.ReadLine();

            if (email.EndsWith("us") || email.EndsWith("uk"))
            {
                continue;
            }

            Console.WriteLine($"{name} -> {email}");
        }
    }
}
