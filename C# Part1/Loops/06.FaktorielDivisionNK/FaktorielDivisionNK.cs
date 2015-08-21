//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

class FaktorielDivisionNK
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger faktorielN = 1;
        BigInteger faktorielK = 1;
        BigInteger faktorielNK = 1;

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
            }
            faktorielNK = faktorielN / faktorielK;
            Console.WriteLine(faktorielNK);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}


