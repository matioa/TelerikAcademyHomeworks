//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter numbers separated by comma: ");
        string[] inputElements = Console.ReadLine().Split(',');
        int counter = 1;
        int repeatingElement = 0;
        int repeatingTimes = 1;
        
        //Convert string array to int array.
        int[] numElements = new int[inputElements.Length];

        for (int i = 0; i < inputElements.Length; i++)
        {
            numElements[i] = int.Parse(inputElements[i]);
        }

        //Find the longest sequence
        for (int i = 0; i < numElements.Length - 1; i++)
        {
            if (numElements[i]+1 == numElements[i + 1])
            {
                counter++;
                if (repeatingTimes < counter)
                {
                    repeatingTimes = counter;
                    repeatingElement = numElements[i+1];
                }
            }
            else
            {
                counter = 1;
            }
        }
        
        //Print the sequence
        for (int i = repeatingTimes; i >0; i--)
        {
            if (i ==1)
            {
                Console.Write("{0}", repeatingElement);
            }
            else
            {
                Console.Write("{0},", repeatingElement-i+1);
            }
        }
        Console.WriteLine();
    }
}
