//Problem 2. Binary to decimal
//• Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string input = Console.ReadLine();
        foreach (char item in input)
        {
            if (item != '0' && item != '1')
            {
                Console.WriteLine("The entered number is not binary.");
                return;
            }
        }

        double numberInDec = BinToDec(input);
        Console.WriteLine(numberInDec);
    }

    static double BinToDec(string binNumber)
    {
        char[] binary = binNumber.ToCharArray();
        var revBinary = binary.Reverse();

        double number = 0;
        int position = 0;
        foreach (var item in revBinary)
        {
            number += (int)char.GetNumericValue(item) * Math.Pow(2, position);
            position++;
        }

        return number;
    }
}
