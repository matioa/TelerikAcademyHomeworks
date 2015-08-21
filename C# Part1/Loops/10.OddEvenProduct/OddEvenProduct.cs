//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter integers with a space between them:");
        string text = Console.ReadLine().Trim();
        string[] num = text.Split();
        int sumOdd = 1;
        int sumEven = 1;
        for (int i = 0; i < num.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumOdd *= int.Parse(num[i]);
            }
            else
            {
                sumEven *= int.Parse(num[i]);
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
