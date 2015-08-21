//Problem 5. Workdays
//• Write a method that calculates the number of workdays between today and given date, passed as parameter.
//• Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


using System;
using System.Collections.Generic;
using System.Linq;

class Workdays
{
    static DateTime currentDate = DateTime.Today;


    static void Main()
    {
        Console.WriteLine("Enter date from today to count the working days: ");
        string input = Console.ReadLine();
        DateTime endDate = new DateTime();

        if (input.GetType() != typeof(DateTime))
        {
            endDate = DateTime.Parse(input);
        }
        else
        {
            Console.WriteLine("Not a valid date");
            return;
        }

        if (currentDate > endDate)
        {
            Console.WriteLine("End date is before current date.");
            return;
        }

        Console.WriteLine(WorkingDays(endDate));
    }

    static int WorkingDays(DateTime end)
    {

        List<DateTime> holidays = new List<DateTime>();
        holidays.Add(new DateTime(2015, 01, 01));
        holidays.Add(new DateTime(2015, 01, 02));
        holidays.Add(new DateTime(2015, 03, 02));
        holidays.Add(new DateTime(2015, 03, 03));
        holidays.Add(new DateTime(2015, 04, 10));
        holidays.Add(new DateTime(2015, 04, 10));
        holidays.Add(new DateTime(2015, 04, 13));
        holidays.Add(new DateTime(2015, 05, 01));
        holidays.Add(new DateTime(2015, 05, 06));
        holidays.Add(new DateTime(2015, 09, 21));
        holidays.Add(new DateTime(2015, 09, 22));
        holidays.Add(new DateTime(2015, 12, 24));
        holidays.Add(new DateTime(2015, 12, 25));
        holidays.Add(new DateTime(2015, 12, 31));


        DateTime tmpDate = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day);
        int[] weekdays = { 6, 7 };
        int workdaysCount = 0;

        while (tmpDate != end)
        {
            if (!weekdays.Contains((int)tmpDate.DayOfWeek) && !holidays.Contains(tmpDate))
            {
                workdaysCount++;
            }
            tmpDate = tmpDate.AddDays(1);
        }
        return workdaysCount;



    }
}

