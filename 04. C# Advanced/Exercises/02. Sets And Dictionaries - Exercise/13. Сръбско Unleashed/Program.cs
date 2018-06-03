using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// !!! ATTENTION !!! This task was solved, thanks to listening to very very much hardcore HEAVY METAL on 7.1 audio system, while solving
/// </summary>
class СръбскоUnleashed
{
    static void Main()
    {
        string input;
        Dictionary<string, Dictionary<string, long>> concerts = new Dictionary<string, Dictionary<string, long>>();
        while (true)
        {
            long ticketsPrice = 0;
            long ticketsCount = 0;
            string cringeSinger = "";
            string venue = "";

            // Reading shits from the console
            input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            else
            {
                string[] singerAndRest = input
                    .Split(new string[] { " @" }, StringSplitOptions.None)
                    .ToArray();

                if (singerAndRest.Count() != 2)
                {
                    continue;
                }
                else
                {
                    cringeSinger = singerAndRest[0];

                    string[] venueAndTickets = singerAndRest[1]
                        .Split(' ')
                        .Reverse()
                        .ToArray();

                    long temp;
                    if (!(long.TryParse(venueAndTickets[0], out temp)) ||
                        !(long.TryParse(venueAndTickets[1], out temp)))
                    {
                        continue;
                    }
                    else
                    {
                        ticketsCount = long.Parse(venueAndTickets[0]);
                        ticketsPrice = long.Parse(venueAndTickets[1]);
                        venue = string.Join(" ", venueAndTickets
                            .Skip(2)
                            .Reverse());
                    }
                }
            }

            // Adding the new data about heists in dictionary
            long stolenMoney = ticketsPrice * ticketsCount;

            if (concerts.ContainsKey(venue))
            {
                if (concerts[venue].ContainsKey(cringeSinger))
                {
                    concerts[venue][cringeSinger] += stolenMoney;
                }
                else
                {
                    concerts[venue][cringeSinger] = stolenMoney;
                }
            }
            else
            {
                concerts.Add(venue, new Dictionary<string, long> { { cringeSinger, stolenMoney } });
            }

        }

        // Ordering the cringe singers by amount of stolen money
        for (int i = 0; i < concerts.Count; i++)
        {
            var item = concerts.ElementAt(i);

            concerts[item.Key] = concerts[item.Key]
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
        }


        // Printing the result of robberies
        foreach (var vnue in concerts)
        {
            Console.WriteLine(vnue.Key);

            foreach (var item in vnue.Value)
            {
                Console.WriteLine("#  {0} -> {1}",
                    item.Key, item.Value);
            }
        }
    } // Thanks to my patention - finaly end =P
}