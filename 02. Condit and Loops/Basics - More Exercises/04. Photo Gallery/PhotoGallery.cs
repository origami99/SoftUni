using System;

class PhotoGallery
{
    static void Main()
    {
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        double photoSize = double.Parse(Console.ReadLine()); // The given size is in Bytes
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");

        Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");

        string sizeFormat = "B";
        if (photoSize >= 1000)
        {
            photoSize = photoSize / 1000.0;
            sizeFormat = "KB";
        }
        if (photoSize >= 1000)
        {
            photoSize = photoSize / 1000.0;
            sizeFormat = "MB";
        }

        Console.WriteLine($"Size: {Math.Round(photoSize, 1)}{sizeFormat}");

        string orientation = "";
        if (width < height)
        {
            orientation = "portrait";
        }
        else if (width > height)
        {
            orientation = "landscape";
        }
        else
        {
            orientation = "square";
        }

        Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
    }
}
