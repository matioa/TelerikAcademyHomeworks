//Problem 3. English digit
//• Write a method that returns the last digit of given integer as an English word.


using System;

class EnglishtDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a some number: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit of number {0} is {1}", input, LastDigitAsWord(input));

    }

    static string LastDigitAsWord(int number)
    {
        int lastDigit = Math.Abs(number) % 10;
        string[] digitStrings = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        return digitStrings[lastDigit];
    }
}

