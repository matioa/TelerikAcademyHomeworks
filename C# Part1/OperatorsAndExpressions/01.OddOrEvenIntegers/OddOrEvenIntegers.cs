//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine(" n | Odd?");
        Console.WriteLine();

        int someNumber;
        bool isEven=new bool();
        // Checks the number from -5 to 10.
        for (someNumber = -5; someNumber <= 10; someNumber++)
        {
            isEven = someNumber % 2 == 0;
            Console.WriteLine("{0,2} | {1}",someNumber,!isEven);
        }

        // Asks fo number from the user:
        while (true)
        {
            Console.Write("Enter number:");
            someNumber = Convert.ToInt32(Console.ReadLine());
            isEven = someNumber % 2 == 0;
            Console.WriteLine("{0,2} | {1}", someNumber, !isEven);
        }
    }
}