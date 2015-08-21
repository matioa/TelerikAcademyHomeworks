//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class After10Years
{
    static void Main()
    {
        Console.Write("Enter your birth date: ");
        DateTime birthDay = Convert.ToDateTime(Console.ReadLine());
        DateTime currentDate = DateTime.Now; 
            
        int currentAge = (currentDate - birthDay).Days / 365;
        int ageAfter = currentAge + 10;

        Console.WriteLine("You are {0} years old", currentAge);
        Console.WriteLine("After ten years you will be {0} years old",ageAfter);
    }
}