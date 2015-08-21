//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        float thirdtNumber = float.Parse(Console.ReadLine());
        float sum = firstNumber + secondNumber + thirdtNumber;
        Console.WriteLine("{0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdtNumber, sum);
        Console.WriteLine();

    }
}

