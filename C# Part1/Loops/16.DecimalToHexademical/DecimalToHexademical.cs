//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToHexademical
{
    static void Main()
    {
        //Console.WriteLine("Enter number: ");
        long numberInDecimal = long.Parse(Console.ReadLine());
        string numberInHex = "";

        while (numberInDecimal>0)
        {
            int numbers=0;
            numbers = (int)(numberInDecimal % 16);
            string oneSymbol = "";
            switch (numbers)
            {
                case 0: oneSymbol= "0"; break;
                case 1: oneSymbol= "1"; break;
                case 2: oneSymbol= "2"; break;
                case 3: oneSymbol= "3"; break;
                case 4: oneSymbol= "4"; break;
                case 5: oneSymbol= "5"; break;
                case 6: oneSymbol= "6"; break;
                case 7: oneSymbol= "7"; break;
                case 8: oneSymbol= "8"; break;
                case 9: oneSymbol= "9"; break;
                case 10:oneSymbol = "A"; break;
                case 11:oneSymbol = "B"; break;
                case 12:oneSymbol = "C"; break;
                case 13:oneSymbol = "D"; break;
                case 14:oneSymbol = "E"; break;
                case 15:oneSymbol = "F"; break;
            }
            numberInHex = oneSymbol + numberInHex;
            numberInDecimal = (numberInDecimal / 16);
        }
        Console.WriteLine(numberInHex);
    }
}

