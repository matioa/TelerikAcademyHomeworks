//Problem 4. Hexadecimal to decimal
//• Write a program to convert hexadecimal numbers to their decimal representation.


using System;
using System.Linq;

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter a Hexadecimal number: ");
        string input = Console.ReadLine();

        //Check if the entered number is Hexadecimal
        string hexElements = "0123456789ABCDEF";
        foreach (var item in input)
        {
            if (!(hexElements.Contains(item)))
            {
                Console.WriteLine("The entered number is not Hexadecimal");
                return;
            }
        }

        double toDecimal = HexToDec(input);
        Console.WriteLine(toDecimal);
    }

    static double HexToDec(string hexNumber)
    {
        double number = 0;
        string hexElements = "0123456789ABCDEF";

        var revHex = hexNumber.Reverse();
        int counter = 0;
        foreach (var item in revHex)
        {
            int position = hexElements.IndexOf(item);
            number += position * (Math.Pow(16, counter));
            counter++;
        }
        return number;
    }
}

        //INTERESTING
        //Console.WriteLine("Please input a hexadecimal number :");
        //string hexValue = Console.ReadLine();
        //int decValue = Convert.ToInt32(hexValue, 16);
        //Console.WriteLine("Your number represented as a decimal value is : {0}", decValue);