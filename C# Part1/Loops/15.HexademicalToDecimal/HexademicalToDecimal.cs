//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.IO;

class HexademicalToDecimal
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\Input.txt");
        //Console.SetIn(reader);

        Console.Write("Enter Hexadecimal number: ");

        string userInput = Console.ReadLine();
        int stringLength = userInput.Length;
        long numberInDecimal = 0;

        for (int i = 0; i < stringLength; i++)
        {
            int number = 0;
            string a = userInput.Substring(stringLength - 1 - i, 1);
            switch (a)
            {
                case "0": number = 0; break;
                case "1": number = 1; break;
                case "2": number = 2; break;
                case "3": number = 3; break;
                case "4": number = 4; break;
                case "5": number = 5; break;
                case "6": number = 6; break;
                case "7": number = 7; break;
                case "8": number = 8; break;
                case "9": number = 9; break;
                case "A": number = 10; break;
                case "B": number = 11; break;
                case "C": number = 12; break;
                case "D": number = 13; break;
                case "E": number = 14; break;
                case "F": number = 15; break;
            }
            numberInDecimal += (long)number * (long)Math.Pow(16, i);
        }
        Console.WriteLine(numberInDecimal);
    }
}

