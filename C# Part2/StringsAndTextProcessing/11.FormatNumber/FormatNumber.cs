//Problem 11. Format number

//    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//    Format the output aligned right in 15 symbols.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D}",(int)number);
        Console.WriteLine("{0,15:X}", (int)number);
        Console.WriteLine("{0,15:P2}", number);
        Console.WriteLine("{0,15:E}", number);
    }
}

