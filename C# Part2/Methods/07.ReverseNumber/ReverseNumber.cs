//Problem 7. Reverse number
//• Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        char[] input = Console.ReadLine().ToCharArray();
        string reverseNumber = ReverseDigits(input);
        Console.WriteLine("\nReversed Number is {0}", reverseNumber);

    }

    static string ReverseDigits(char[] digits)
    {
        char[] reverseDigits = new char[digits.Length];
        int counter = 0;
        for (int i = digits.Length-1; i >= 0; i--)
        {
            reverseDigits[counter] = digits[i];
            counter++;
        }
        string result = new string(reverseDigits);
        return result;
    }
}

