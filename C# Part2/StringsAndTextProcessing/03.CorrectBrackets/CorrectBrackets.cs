//Problem 3. Correct brackets
//    Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string input = Console.ReadLine();
        StringBuilder inputBuilder = new StringBuilder();
        int countOpeningBracket = 0;

        foreach (var item in input)
        {
            if (item == '(')
            {
                ++countOpeningBracket;
            }
            if (item == ')' && countOpeningBracket ==0)
            {
                    inputBuilder.Append('(');
                    ++countOpeningBracket;
            }
            else if (item ==')' && countOpeningBracket>0)
            {
                --countOpeningBracket;
                inputBuilder.Append(item);
            }
            else
            {
                inputBuilder.Append(item);
            }
        }
        Console.WriteLine(inputBuilder);
        
    }
}

