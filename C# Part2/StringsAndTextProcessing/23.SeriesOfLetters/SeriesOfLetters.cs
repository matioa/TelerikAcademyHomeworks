//Problem 23. Series of letters
//    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SeriesOfLetters
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder result = new StringBuilder();
        int index = 0;

        while (index < input.Length)
        {
            result.Append(input[index]);
            for (int i = index+1; i < input.Length; i++)
            {
                if (input[index]!=input[i])
                {
                    break;
                }
                index = i;
            }
            index++;
        }
        Console.WriteLine(result);


    }
}

