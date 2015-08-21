//Problem 6. String length
//    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//    Print the result string into the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string input = Console.ReadLine();
        int resultLength = 20;
        StringBuilder result = new StringBuilder();

        if (input.Length>=resultLength)
        {
            result.Append(input.Substring(0, resultLength));
        }
        else
        {
            result.Append(input);
            result.Append('*', resultLength - input.Length);
        }

        Console.WriteLine(result);
    }
}

