using System;

class CountTheIntegers
{
    static void Main()
    {
        int number = 0;
        int counter = 0;

        try
        {
            while (true)
            {
                number = int.Parse(Console.ReadLine());
                counter++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine(counter);
        }
    }
}
