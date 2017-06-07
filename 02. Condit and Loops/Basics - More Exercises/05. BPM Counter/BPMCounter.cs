using System;

class BPMCounter
{
    static void Main()
    {
        double bpm = double.Parse(Console.ReadLine());
        double numberOfBeats = double.Parse(Console.ReadLine());

        double bars = numberOfBeats / 4.0d;
        double seconds = (bars * 4) / bpm * 60;

        Console.WriteLine($"{Math.Round(bars, 1)} bars - {Math.Floor(seconds / 60)}m {Math.Floor(seconds % 60)}s");

        // Minutes = RoundDown(((Bars x beats per bar)/ BPM) x 60)
        // Seconds = (((Bars x beats per bar) / BPM) x 60) x 60
    }
}
