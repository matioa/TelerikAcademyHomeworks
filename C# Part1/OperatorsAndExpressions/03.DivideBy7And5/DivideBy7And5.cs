//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("  number | Divided by 7 and 5?");
        bool isDividedBy7 = new bool();
        bool isDividedBy5 = new bool();

        while (true)
        {
            Console.WriteLine();
            Console.Write("Enter number:");
            int someNumber = Convert.ToInt32(Console.ReadLine());
            isDividedBy7 = someNumber % 7 == 0;
            isDividedBy5 = someNumber % 5 == 0;
            Console.WriteLine("{0,3} | {1}", someNumber, isDividedBy7 && isDividedBy5);   
        }

    }
}

