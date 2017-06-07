using System;

class PrintPartOfASCIITable
{
    static void Main()
    {
        int begin = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for (int i = begin; i <= end; i++)
            Console.Write(Convert.ToChar(i) + " ");
    }
}
