using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> kids = Console.ReadLine().Split().ToList();
        int n = int.Parse(Console.ReadLine());

        Queue<string> loosers = new Queue<string>();
        int pos = 0;
        while (kids.Count != 1)
        {
            // Намераме позицията на загубилия
            pos += n - 1;
            if (pos >= kids.Count)
            {
                pos = pos % kids.Count;
            }

            // Махаме загубилия от списъка с играчите и го добавяме в списъка на губещите
            string looser = kids[pos];
            loosers.Enqueue(looser);
            kids.RemoveAt(pos);
        }


        while (loosers.Count != 0)
        {
            Console.WriteLine($"Removed {loosers.Dequeue()}");
        }
        Console.WriteLine($"Last is {kids.First()}");
    }
}