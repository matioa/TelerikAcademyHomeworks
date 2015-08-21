//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.WriteLine("Enters 3 integers: n, min and max (min != max)");
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter min: ");
        int numMin = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter max: ");
        int numMax = int.Parse(Console.ReadLine());
        int number = 0;

        if (numMax < numMin)
        {
            Console.WriteLine("invalid input");
        }
        else
        {
            Random randomGeneratedNumber = new Random();
            for (int i = 0; i < n; i++)
            {
                number = randomGeneratedNumber.Next(numMin,numMax);
                Console.Write("{0} ",number);
            }
        }
        Console.WriteLine();
    }
}

