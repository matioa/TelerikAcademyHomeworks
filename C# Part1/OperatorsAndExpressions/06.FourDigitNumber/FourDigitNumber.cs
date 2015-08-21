//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 4 digit number. Do not start with 0:");
        char a = Convert.ToChar(Console.Read());
        int checkFirstDigit = a - '0';
        bool fisrtIsZero = checkFirstDigit == 0;
        
        //Checks if the first digit is zero and asks for a new number. Loops this until a digit without 0 as first is entered.
        if (fisrtIsZero)
        {
            do {
                Console.WriteLine("The number cannot start with 0. Enter 4 digit number:");
                Console.ReadLine();
                a = Convert.ToChar(Console.Read());
                checkFirstDigit = a - '0';
                fisrtIsZero = checkFirstDigit == 0;
            }while (fisrtIsZero);
        }
        char b = Convert.ToChar(Console.Read());
        char c = Convert.ToChar(Console.Read());
        char d = Convert.ToChar(Console.Read());

        int num1 = a - '0';
        int num2 = b - '0';
        int num3 = c - '0';
        int num4 = d - '0';
        int sumNumbers = num1 + num2 + num3 + num4;

        Console.WriteLine();
        Console.WriteLine("Sum of the digits is: {0}+{1}+{2}+{3}={4}", num1, num2, num3,num4, sumNumbers);
        Console.WriteLine("Digits in reverse order: {0}, {1}, {2}, {3}", num4, num3, num2, num1);
        Console.WriteLine("Last digit in first position: {0}, {1}, {2}, {3}", num4, num1, num2, num3);
        Console.WriteLine();
    }
}

