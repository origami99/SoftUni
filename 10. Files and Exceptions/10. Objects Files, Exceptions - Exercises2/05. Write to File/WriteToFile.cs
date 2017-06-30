using System;
using System.IO;
using System.Text.RegularExpressions;

class WriteToFile
{
    static void Main()
    {
        string text = File.ReadAllText("sample_text.txt");
        string textWithoutMarks = Regex.Replace(text, "[.,!?:]", "");

        File.Create("output.txt").Close();
        File.WriteAllText("output.txt", textWithoutMarks);
    }
}
