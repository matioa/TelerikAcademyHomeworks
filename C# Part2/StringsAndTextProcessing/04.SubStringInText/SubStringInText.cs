//Problem 4. Sub-string in text
//    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubStringInText
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine().ToLower();
        Console.Write("\nEnter target sub-string: ");
        string textPart = Console.ReadLine().ToLower();
        int countTextPart = 0;
        int index = text.IndexOf(textPart);

        while(index>=0)
        {
            ++countTextPart;
            index= text.IndexOf(textPart,index+1);
        }

        Console.WriteLine(countTextPart);
    }
}

