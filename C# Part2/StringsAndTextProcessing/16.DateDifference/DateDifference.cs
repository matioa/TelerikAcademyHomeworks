//Problem 16. Date difference
//    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter date 1 in format dd.mm.yyyy: ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter date 2 in format dd.mm.yyyy: ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Distance: {0} days",(date2-date1).TotalDays);
    }
}