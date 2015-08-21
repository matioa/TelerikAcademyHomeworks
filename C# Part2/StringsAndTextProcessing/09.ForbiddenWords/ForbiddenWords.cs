//Problem 9. Forbidden words
//    We are given a string containing a list of forbidden words and a text containing some of these words.
//    Write a program that replaces the forbidden words with asterisks.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
        StringBuilder censoredText = new StringBuilder(text);

        foreach (var item in forbiddenWords)
        {
            censoredText.Replace(item, new string('*', item.Length));
        }
        Console.WriteLine(censoredText);
    }
}

