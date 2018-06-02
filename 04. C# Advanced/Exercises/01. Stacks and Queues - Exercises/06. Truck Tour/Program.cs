using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Queue<KeyValuePair<int, int>> pumpData = new Queue<KeyValuePair<int, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int amountPetrol = int.Parse(input.First());
            int distance = int.Parse(input.Last());

            KeyValuePair<int, int> pair = new KeyValuePair<int, int>(amountPetrol, distance);
            pumpData.Enqueue(pair);
        }

        int index = 0;
        for (int i = 0; i < n; i++)
        {
            int truckFuel = 0;

            for (int j = 0; j < pumpData.Count; j++)
            {
                Queue<KeyValuePair<int, int>> pumpDataCopy = new Queue<KeyValuePair<int, int>>(pumpData);

                KeyValuePair<int, int> pair = pumpDataCopy.Dequeue();
                int amountPetrol = pair.Key;
                int distance = pair.Value;

                truckFuel += amountPetrol;
                truckFuel -= distance;

                if (truckFuel < 0)
                {
                    break;
                }
            }

            if (truckFuel >= 0)
            {
                break;
            }

            KeyValuePair<int, int> element = pumpData.Dequeue(); // Removing last elem
            pumpData.Enqueue(element); // Setting it as first elem

            index++;
        }

        Console.WriteLine(index);
    }
}