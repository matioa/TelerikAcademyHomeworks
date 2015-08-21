using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WordsCount
{
    static void Main()
    {
        string sampleText = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found 5555";
        char[] separator = " .,;?!-".ToCharArray();
        string[] words = sampleText.Split(separator,StringSplitOptions.RemoveEmptyEntries);
        HashSet<string> uniqueWords = new HashSet<string>();
        foreach (var word in words)
        {
            uniqueWords.Add(word);
        }
        foreach (var word in uniqueWords)
        {
            int counter = words.Count(w => w.CompareTo(word)==0);
            Console.WriteLine("Word {0} - {1} times", word, counter);
        }
    }
}

