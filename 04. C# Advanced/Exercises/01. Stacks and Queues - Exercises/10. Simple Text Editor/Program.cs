using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string text = string.Empty;
        Stack<string> historyData = new Stack<string>();
        historyData.Push(text);

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' '); // the second string may contains spaces 
            int num = int.Parse(input[0]);

            switch (num)
            {
                case 1:
                    string str = input[1];
                    text += str;
                    historyData.Push(text);
                    break;
                case 2:
                    int count = int.Parse(input[1]);
                    int startIndex = text.Length - count;
                    text = text.Remove(startIndex);
                    historyData.Push(text);
                    break;
                case 3:
                    int index = int.Parse(input[1]) - 1;
                    char elem = text[index];
                    Console.WriteLine(elem);
                    break;
                case 4:
                    historyData.Pop();
                    text = historyData.Peek();
                    break;
            }
        }
    }
}
