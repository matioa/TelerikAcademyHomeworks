//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        int[] alphabetNumber = Enumerable.Range(65, 26).ToArray();
        char[] alphabet = new char[alphabetNumber.Length];

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToChar(alphabetNumber[i]);
        }

        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine().ToUpper();
        Console.WriteLine();

        //Print position of each letter in the alphabet.
        foreach (char letter in word)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    Console.WriteLine("{0}  letter number --> {1}", letter, i);
                }
            }
        }
        Console.WriteLine();
    }
}
