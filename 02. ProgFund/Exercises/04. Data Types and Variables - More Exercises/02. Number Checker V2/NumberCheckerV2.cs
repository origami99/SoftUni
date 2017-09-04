using System;

class NumberCheckerV2
{
    static void Main()
    {
        try
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine("integer");
        }
        catch (Exception)
        {
            Console.WriteLine("floating-point");
        }
    }
}
