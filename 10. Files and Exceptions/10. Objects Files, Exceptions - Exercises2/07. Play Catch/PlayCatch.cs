using System;
using System.Linq;

class PlayCatch
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();

        byte countExceptions = 0;
        while (countExceptions < 3)
        {
            string[] commands = Console.ReadLine().Split(' ');

            switch (commands[0])
            {
                case "Replace":
                    try
                    {
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                        nums[index] = element;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        countExceptions++;
                        Console.WriteLine("The index does not exist!");
                    }
                    catch (FormatException)
                    {
                        countExceptions++;
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                    break;
                case "Print":
                    try
                    {
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);

                        // I know it's not the best solution, but it works! =D
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            nums[i] = nums[i];
                        }

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if (i != endIndex)
                            {
                                Console.Write($"{nums[i]}, ");
                            }
                            else
                            {
                                Console.WriteLine(nums[i]);
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        countExceptions++;
                        Console.WriteLine("The index does not exist!");
                    }
                    catch (FormatException)
                    {
                        countExceptions++;
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                    break;
                case "Show":
                    try
                    {
                        int index = int.Parse(commands[1]);
                        Console.WriteLine(nums[index]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        countExceptions++;
                        Console.WriteLine("The index does not exist!");
                    }
                    catch (FormatException)
                    {
                        countExceptions++;
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", nums));
    }
}
