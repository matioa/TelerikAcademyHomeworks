//Problem 8. Extract sentences
//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractSentence
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = " in ";
        string[] splitter = { "." };
        string[] sentences = text.Split(splitter, StringSplitOptions.None);
        var selectedSentences = sentences.Where(sen => sen.ToLower().Contains(word));

        Console.Write(string.Join(".", selectedSentences));
        Console.WriteLine();
    }
}

