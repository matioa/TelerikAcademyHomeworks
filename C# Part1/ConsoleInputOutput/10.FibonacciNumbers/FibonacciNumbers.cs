//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        ulong a = 0L;
        ulong b = 1L;
        Console.Write("{0}, ", a);
        if (n >=2)
        {
            Console.Write("{0}, ", b);
        }
        for (int i=0; i< n-2 ;  i++)
        {
            ulong sum = a + b;	
            Console.Write("{0}, ",sum);
            a = b;
            b = sum;
        }
        Console.WriteLine();
    }
}
