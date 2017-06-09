using System;
using System.Linq;

class SafeManipulation
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Reverse")
            {
                Reverse(ref arr);
            }
            else if (command == "Distinct")
            {
                Distinct(ref arr);
            }
            else if (command.StartsWith("Replace"))
            {
                Replace(ref arr, command);
            }
            else if (command == "END")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        Console.WriteLine(string.Join(", ", arr));
    }

    private static void Reverse(ref string[] arr)
    {
        arr = arr.Reverse().ToArray();
    }

    private static void Distinct(ref string[] arr)
    {
        arr = arr.Distinct().ToArray();
    }

    private static void Replace(ref string[] arr, string command)
    {
        string[] replaceCommands = command.Split(' ').ToArray();

        int index = int.Parse(replaceCommands[1]);
        string strForReplace = replaceCommands[2];

        if (index >= 0 && index < arr.Length)
        {
            arr[index] = strForReplace;
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
