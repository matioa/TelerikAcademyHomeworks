//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter first floating point number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second floating point number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        double result = Math.Abs(firstNumber - secondNumber);
        float eps = 0.000001f;

        if(result>=eps)
        {
            Console.WriteLine("The two numbers are NOT equal (calculated with precision {0:F6})", eps);
        }
        else
        {
            Console.WriteLine("The two numbers ARE equal (calcualted with precision {0:F6})", eps);
        }
        Console.WriteLine();
    }
}
