using System;
using System.Linq;

class ManipulateArray
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
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

        arr[index] = strForReplace;
    }
}
