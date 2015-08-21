//Problem 20. Palindromes
//    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Palindromes
{
    static void Main()
    {
        string sampleText = "exe some text haah ABBA, lamal,";
        char[] separator = " -.,;?!".ToCharArray();
        string[] words = sampleText.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;

        foreach (var word in words)
        {
            char[] reverse = word.Reverse().ToArray();
            string wordInReverse = string.Join("", reverse);
            if (word.CompareTo(wordInReverse)==0)
            {
                Console.WriteLine("word: {0} - Reverse: {1}", word, wordInReverse);
                ++counter;
            }
        }
        Console.WriteLine("\nTotal palindormes: {0}", counter);
    }
}

