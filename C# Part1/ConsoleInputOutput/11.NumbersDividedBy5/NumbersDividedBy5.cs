//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersDividedBy5
{
    static void Main()
    {
        Console.Write("Enter positive number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter positive number b: ");
        int b = int.Parse(Console.ReadLine());
        a = Math.Abs(a);
        b = Math.Abs(b);
        int num1 = Math.Min(a,b);
        int num2 = Math.Max(a,b);
        int countP = 0;

        for (int i=num1; i<=num2; i++)
        {
	        if (i % 5 == 0)
	        {
                countP++;
	        }
        }
        Console.WriteLine("There are {0} numbers that are divided by 5 with reminder 0", countP);
    }
}

