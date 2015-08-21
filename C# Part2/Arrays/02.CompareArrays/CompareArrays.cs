//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter a few numbers separated by space: ");
        string userInput1 = Console.ReadLine().Trim();
        Console.WriteLine("Enter other or the same numbers again separated by space: ");
        string userInput2 = Console.ReadLine().Trim();
        string[] numbers1 = userInput1.Split(' ');
        string[] numbers2 = userInput2.Split(' ');
        bool areEqual = true;

        if (numbers1.Length == numbers2.Length)
        {
            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine("The numbers in the two arrays are equal = {0}", areEqual);
        }
        else
        {
            Console.WriteLine("The two arrays have different length.");
        }
    }
}
