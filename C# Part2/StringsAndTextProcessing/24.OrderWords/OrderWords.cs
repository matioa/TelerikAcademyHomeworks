//Problem 24. Order words
//    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class OrderWords
    {
        static void Main()
        {
            string sampleText = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found 5555";
            char[] separator = " .,;?!-".ToCharArray();
            string[] words = sampleText.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var sortedWords = words.OrderBy(w => w);
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }

        }
    }

