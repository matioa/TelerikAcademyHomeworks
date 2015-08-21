//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        float a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        float b = int.Parse(Console.ReadLine());
        float temp;
        if (a > b)
        {
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

