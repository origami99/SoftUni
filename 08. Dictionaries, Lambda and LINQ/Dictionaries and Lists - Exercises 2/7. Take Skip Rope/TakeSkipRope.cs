using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TakeSkipRope
{
    static void Main()
    {
        string encryptedMessage = Console.ReadLine();

        List<int> numbers = encryptedMessage
            .Where(s => char.IsDigit(s))
            .Select(s => int.Parse(s.ToString()))
            .ToList();
        List<char> nonNumbers = encryptedMessage
            .Where(s => !char.IsDigit(s))
            .ToList();

        List<int> takeList = numbers
            .Where((x, i) => i % 2 == 0)
            .ToList();
        List<int> skipList = numbers
            .Where((x, i) => i % 2 != 0)
            .ToList();


        var skipCounter = 0;
        var message = new StringBuilder();
        for (int i = 0; i < skipList.Count; i++)
        {
            var currentDecryptedPart = new string(nonNumbers.Skip(skipCounter).Take(takeList[i]).ToArray());
            message.Append(currentDecryptedPart);
            skipCounter += skipList[i] + takeList[i];
        }

        Console.WriteLine(message.ToString());
    }
}
