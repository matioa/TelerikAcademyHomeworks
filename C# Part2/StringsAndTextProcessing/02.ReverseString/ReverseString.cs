//Problem 2. Reverse string
//    Write a program that reads a string, reverses it and prints the result at the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string input = Console.ReadLine();
        char[] inputElements = input.ToArray();
        Array.Reverse(inputElements);
        string revInput = new string(inputElements);
        Console.WriteLine(revInput);
    }
}

