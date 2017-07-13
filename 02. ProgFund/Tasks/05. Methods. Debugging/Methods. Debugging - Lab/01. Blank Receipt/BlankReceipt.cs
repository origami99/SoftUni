using System;

class BlankReceipt
{
    static void Main()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }

    public static void PrintHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        PrintDashes();
    }

    public static void PrintBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    public static void PrintFooter()
    {
        PrintDashes();
        Console.WriteLine("© SoftUni");
    }

    public static void PrintDashes()
    {
        Console.WriteLine("------------------------------");
    }
}
