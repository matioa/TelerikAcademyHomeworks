//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter characters separated by comma: ");
        string[] inputElements = Console.ReadLine().Split(',');
        string maxSeqElement = "";
        int counter = 1;
        int maxSeqLength = 1;

        //Find the longest sequence and save the times repeated and the number that is repeated
        for (int i = 0; i < inputElements.Length - 1; i++)
        {
            if (inputElements[i] == inputElements[i + 1])
            {
                counter++;
                if (maxSeqLength < counter)
                {
                    maxSeqLength = counter;
                    maxSeqElement = inputElements[i];
                }
            }
            else
            {
                counter = 1;
            }
        }

        //Print the sequence
        for (int i = 0; i < maxSeqLength; i++)
        {
            if (i == maxSeqLength - 1)
            {
                Console.Write("{0}", maxSeqElement);
            }
            else
            {
                Console.Write("{0},", maxSeqElement);
            }
        }
        Console.WriteLine();
    }
}
