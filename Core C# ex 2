using System;

class Exercise6
{
    static void Main()
    {
        Console.Write("Input distance (meters): ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Input hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Input minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("Input seconds: ");
        int seconds = int.Parse(Console.ReadLine());

        int totalSeconds = hours * 3600 + minutes * 60 + seconds;
        double speedMps = distance / totalSeconds;
        double speedKmph = speedMps * 3.6;
        double speedMph = speedMps * 2.236936;

        Console.WriteLine("Your speed in metres/sec is " + speedMps);
        Console.WriteLine("Your speed in km/h is " + speedKmph);
        Console.WriteLine("Your speed in miles/h is " + speedMph);
    }
}
