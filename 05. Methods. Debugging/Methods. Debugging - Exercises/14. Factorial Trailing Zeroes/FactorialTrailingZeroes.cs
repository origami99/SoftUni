using System;
using System.Numerics;

namespace Niki.Education
{
    class FactorialTrailingZeroes
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Math.Pow(1, 4);
            BigInteger result = 1;
            while (n >= 1)
            {
                result *= n;
                n--;
            }

            int endZeros = Count.ZerosInTheEnd(result);
            Console.WriteLine(endZeros);
        }
    }

    ///<summary>
    ///Poor class, that counts some things.
    ///</summary>
    class Count
    {
        /// <summary>
        /// Returns number of zeroes in the end of integer number.
        /// </summary>
        public static int ZerosInTheEnd(BigInteger result)
        {
            int counter = 0;

            while (result % 10 == 0)
            {
                result /= 10;
                counter++;
            }

            return counter;
        }
    }
}