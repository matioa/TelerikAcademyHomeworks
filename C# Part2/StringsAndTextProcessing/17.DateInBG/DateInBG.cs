//Problem 17. Date in Bulgarian
//    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
//the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class DateInBG
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        
        string format = "d.M.yyyy HH:mm:ss";
        CultureInfo provider = CultureInfo.GetCultureInfo("BG-bg");
        Console.WriteLine("Enter date: {0}", format);
        DateTime date = DateTime.ParseExact(Console.ReadLine(), format, provider);
        date.AddHours(6);
        date.AddMinutes(30);
        Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"));
    }
}
