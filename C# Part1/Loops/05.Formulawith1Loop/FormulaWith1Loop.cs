//problem 5. calculate 1 + 1!/x + 2!/x^2 + … + n!/x^n

//write a program that, for a given two integer numbers n and x, calculates the sum s = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//use only one loop. print the result with 5 digits after the decimal point.

using System;

class FormulaWith1Loop
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number x: ");
        double x = double.Parse(Console.ReadLine());
        decimal result = 1;
        int faktoriel = 1;

        for (int i = 1; i<=n; i++)
        {
            double numX = x;
            faktoriel = (faktoriel*i);
            numX = (double)Math.Pow(numX,i);
            result = (decimal)result + (decimal)(faktoriel/numX);
        }
        Console.WriteLine("{0:F5}",result);
    }
}

