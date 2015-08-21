//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("You should enter {0} numbers to calculate their sum.", n);
        float sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number: ");
            float enteredNumber = float.Parse(Console.ReadLine());
            sum += enteredNumber;
        }
        Console.WriteLine("The sum of the {0} numbers is {1}", n, sum);
    }
}

