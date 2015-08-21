//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n <= 20)
        {
            for (int j = 1; j <= n; j++)
            {
                for (int i = j; i <= n+j-1; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("invalid input");
        }
        Console.WriteLine();
    }
}


