//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float b = float.Parse(Console.ReadLine());
        float biggerNumber = Math.Max(a, b);
        float otherNumber = Math.Min(a,b);
        Console.WriteLine("{0} is bigger than {1}",biggerNumber,otherNumber);
    }
}

