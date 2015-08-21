//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;

class BiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c: ");
        float c = float.Parse(Console.ReadLine());
        float biggestNumber;

        if (a > b)
        {
            if (a > c)
            {
                biggestNumber = a;
            }
            else
                biggestNumber = c;
        }
        else
        {
            if (b > c)
            {
                biggestNumber = b;
            }
            else
            {
                biggestNumber = c;
            }
        }
        Console.WriteLine("Biggest number is {0}", biggestNumber);
    }
}

