//Problem 5. Hexadecimal to binary
//• Write a program to convert hexadecimal numbers to binary numbers (directly).


using System;
using System.Linq;

class HexToBinary
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
        Console.WriteLine(HexToBin(input));

    }

    static string HexToBin(string hexNumber)
    {
        string decNumber = "";
        foreach (var item in hexNumber)
        {
            string part = "";
            switch (item)
            {
                case '0': part = "0000"; break;
                case '1': part = "0001"; break;
                case '2': part = "0010"; break;
                case '3': part = "0011"; break;
                case '4': part = "0100"; break;
                case '5': part = "0101"; break;
                case '6': part = "0110"; break;
                case '7': part = "0111"; break;
                case '8': part = "1000"; break;
                case '9': part = "1001"; break;
                case 'A': part = "1010"; break;
                case 'B': part = "1011"; break;
                case 'C': part = "1100"; break;
                case 'D': part = "1101"; break;
                case 'E': part = "1110"; break;
                case 'F': part = "1111"; break;
            }
            decNumber += part;
        }
        return decNumber;
    }
}

