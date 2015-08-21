//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class FaktorielDivisionNKAdvanced
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        int nMinusK = n - k;

        BigInteger faktorielN = 1;
        BigInteger faktorielK = 1;
        BigInteger faktorielnMinusK = 1;
        BigInteger faktorielNK = 1;

        // Using only 1 Loop
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n >= i)
                {
                    faktorielN *= i;
                }
                if (k >= i)
                {
                    faktorielK *= i;
                }
                if (nMinusK >= i)
                {
                    faktorielnMinusK *= i;
                }
            }
            faktorielNK = faktorielN / (faktorielK * faktorielnMinusK);
            Console.WriteLine(faktorielNK);
        }
        else
        {
            Console.WriteLine("out of range");
        }

    }
}

