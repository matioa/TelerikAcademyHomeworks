//Problem 21. Letters count
//    Write a program that reads a string from the console and prints all 
//different letters in the string along with information how many times each letter is found.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LettersCount
{
    static void Main()
    {
        string sampleText = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found 5555";
        SortedSet<char> uniqueLetters = new SortedSet<char>();
        foreach (var ch in sampleText)
        {
            if (char.IsLetter(ch))
            {
                uniqueLetters.Add(ch);
            }
        }
        foreach (var ch in uniqueLetters)
        {
            int counter = sampleText.Count(t => t.CompareTo(ch)==0);
            Console.WriteLine("Letter {0} - {1} times", ch, counter);
        }
    }
}

