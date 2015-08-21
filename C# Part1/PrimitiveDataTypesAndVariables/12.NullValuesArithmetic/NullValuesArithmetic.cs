//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;

        Console.WriteLine("The first number is: {0}",intNumber);
        Console.WriteLine("The second number is: {0}",doubleNumber);

        int? newIntNumber = intNumber + 10;
        double? newDoubleNumber = doubleNumber + 100;

        Console.WriteLine("The result of Null + 10 = {0}",newIntNumber);
        Console.WriteLine("The result of Null + 100 = {0}",newDoubleNumber);
        Console.WriteLine();
    }
}