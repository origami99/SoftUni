using System;
using System.Linq;

class TypeBoundaries
{
    static void Main()
    {
        string type = Console.ReadLine();

        switch (type)
        {
            case "sbyte":
                Console.WriteLine(sbyte.MaxValue);
                Console.WriteLine(sbyte.MinValue);
                break;
            case "byte":
                Console.WriteLine(byte.MaxValue);
                Console.WriteLine(byte.MinValue);
                break;
            case "short":
                Console.WriteLine(short.MaxValue);
                Console.WriteLine(short.MinValue);
                break;
            case "ushort":
                Console.WriteLine(ushort.MaxValue);
                Console.WriteLine(ushort.MinValue);
                break;
            case "int":
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);
                break;
            case "uint":
                Console.WriteLine(uint.MaxValue);
                Console.WriteLine(uint.MinValue);
                break;
            case "long":
                Console.WriteLine(long.MaxValue);
                Console.WriteLine(long.MinValue);
                break;
            case "ulong":
                Console.WriteLine(ulong.MaxValue);
                Console.WriteLine(ulong.MinValue);
                break;
            case "float":
                Console.WriteLine(float.MaxValue);
                Console.WriteLine(float.MinValue);
                break;
            case "double":
                Console.WriteLine(double.MaxValue);
                Console.WriteLine(double.MinValue);
                break;
            case "decimal":
                Console.WriteLine(decimal.MaxValue);
                Console.WriteLine(decimal.MinValue);
                break;
            case "boolean":
            case "bool":
                Console.WriteLine(true);
                Console.WriteLine(false);
                break;
            case "char":
                Console.WriteLine((int)char.MaxValue);
                Console.WriteLine((int)char.MinValue);
                break;
        }
    }
}
