//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.IO;
using System.Numerics;

class PrimaryToDecimal
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\Input.txt");
        //Console.SetIn(reader);

        Console.Write("Enter binary number: ");
        string userInput = Console.ReadLine();

        BigInteger number = BigInteger.Parse(userInput);
        long numberOutput = 0;
        int inputLength = userInput.Length;
        int counter = 0;

        for (int i = 0; i < inputLength; i++)
        {
            if (number % 10 == 1)
            {
                numberOutput += (long)Math.Pow(2, counter);
                counter++;
                number = number / 10;
            }
            else
            {
                counter++;
                number = number / 10;
            }
        }
        Console.WriteLine(numberOutput);
    }
}

