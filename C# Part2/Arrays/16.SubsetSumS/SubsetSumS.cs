//Problem 16.* Subset with sum S
//• We are given an array of integers and a number  S .
//• Write a program to find if there exists a subset of the elements of the array that has a sum  S 


using System;
using System.Collections.Generic;

class SubsetSumS
{
    static void Main()
    {
        //Set array numbers
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        Console.Write("Enter sum S: ");
        int sumS = int.Parse(Console.ReadLine());

        int counter = 0;
        //Create a list of numbers holding all possible sums from the elements in the int[] numbers
        List<int> posibleSums = new List<int>();

        //Add all sums in the new list
        for (int i = 0; i < numbers.Length; i++)
        {
            posibleSums.Add(numbers[i]);
            counter = posibleSums.Count - 1;
            for (int j = 0; j < counter; j++)
            {
                posibleSums.Add(posibleSums[j] + numbers[i]);
            }
        }

        //Check if the searched sum S is included in the list of possible sums S.
        if (posibleSums.Contains(sumS))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

