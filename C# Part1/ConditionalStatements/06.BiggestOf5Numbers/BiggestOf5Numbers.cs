//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        float c = float.Parse(Console.ReadLine());
        Console.Write("Enter number d: ");
        float d = float.Parse(Console.ReadLine());
        Console.Write("Enter number e: ");
        float e = float.Parse(Console.ReadLine());
        float biggestNumber;

        if (a >= b && a >= c && a >= d && a >= e)
        {
            biggestNumber = a;
        }
        else if (b >= c && b >= d && b >= e)   // if a is not the biggest, then we drop it from the equation and so on for the other numbers
        {
            biggestNumber = b;
        }
        else if (c >= d && c >= e)
        {
            biggestNumber = c;
        }
        else if (d >= e)
        {
            biggestNumber = d;
        }
        else
        {
            biggestNumber = e;
        }
        Console.WriteLine("The biggest number is {0}.", biggestNumber);
        Console.WriteLine();

        // The solution took 4 if statements.
    }
}

