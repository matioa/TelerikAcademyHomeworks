//Problem 1. Square root
//    Write a program that reads an integer number and calculates and prints its square root.
//        If the number is invalid or negative, print Invalid number.
//        In all cases finally print Good bye.
//    Use try-catch-finally block.


using System;

class SquareRoot
{
    static void Main()
    {
        int number = 0;
        double squareRoot = 0;
        Console.Write("Enter number: ");
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentException();
            }
            squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square root of {0} = {1}", number, squareRoot);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Number cannot be negative");
        }
        catch 
        {
            Console.WriteLine("Invalid number");
        }
        finally 
        {
            Console.WriteLine("Good bye");
        }



    }
}

