using System;

class _5DifferentNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        bool isMatching = false;

        for (int i1 = a; i1 <= b; i1++)
        {
            for (int i2 = a; i2 <= b; i2++)
            {
                for (int i3 = a; i3 <= b; i3++)
                {
                    for (int i4 = a; i4 <= b; i4++)
                    {
                        for (int i5 = a; i5 <= b; i5++)
                        {
                            if (i1 < i2 && i1 < i3 && i1 < i4 && i1 < i5 &&
                                i2 < i3 && i2 < i4 && i2 < i5 &&
                                i3 < i4 && i3 < i5 &&
                                i4 < i5)
                            {
                                isMatching = true;
                                Console.WriteLine($"{i1} {i2} {i3} {i4} {i5}");
                            }
                        }
                    }
                }
            }
        }

        if (!(isMatching))
        {
            Console.WriteLine("No");
        }
    }
}
