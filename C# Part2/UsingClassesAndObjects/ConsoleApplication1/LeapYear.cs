//Problem 1. Leap year
//• Write a program that reads a year from the console and checks whether it is a leap one.
//• Use  System.DateTime


using System;
using System.Globalization;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Year {0} is leap? : {1}", year,isLeap);
    }
}

