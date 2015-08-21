using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter time in format H:MM AM/PM");
        DateTime time;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        bool isTime = DateTime.TryParseExact(Console.ReadLine(), "h:mm tt", CultureInfo.InvariantCulture,DateTimeStyles.None, out time);
        if (isTime == false)
        {
            Console.WriteLine("invalid time");
        }
        else if (time >= startTime && time <= endTime)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
}
}
