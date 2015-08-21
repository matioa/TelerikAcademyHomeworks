//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int num1 = 2 * n;
        int num2 = n + 1;
        int num3 = n;

        BigInteger faktorielNum1 = 1;
        BigInteger faktorielNum2 = 1;
        BigInteger faktorielNum3 = 1;

        if (n < 0 || n > 100)
        {
            Console.WriteLine("invalid range");
        }
        else
        {
            for (int i = 1; i <= num1; i++)
            {
                faktorielNum1 *= i;
                if (i <= num2)
                {
                    faktorielNum2 *= i;
                }
                if (i <= num3)
                {
                    faktorielNum3 *= i;
                }
            }
            BigInteger result = faktorielNum1 / (faktorielNum2 * faktorielNum3);
            Console.WriteLine(result);
        }
    }
}


