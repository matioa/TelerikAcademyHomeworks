//Problem 17.* Subset K with sum S
//Write a program that reads three integer numbers  N ,  K  and  S  and an array of  N  elements from the console.
////Find in the array a subset of  K  elements that have sum  S  or indicate about its absence.

using System;
using System.Collections.Generic;

class SubsetSumS
{
    static void Main()
    {
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        Console.Write("Enter sum S: ");
        int sumS = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int subsetK = int.Parse(Console.ReadLine());

        int couter = 0;
        bool result = false;
        //Create two sublists - one holding the possible sums, the other holding the count of numbers the sum was produced.
        List<int> posibleSums = new List<int>();
        List<int> countSum = new List<int>();

        //Add all sums in the new list and add the number of elements forming the sum in the other list.
        for (int i = 0; i < numbers.Length; i++)
        {
            posibleSums.Add(numbers[i]);
            countSum.Add(1);
            couter = posibleSums.Count - 1;
            for (int j = 0; j < couter; j++)
            {
                posibleSums.Add(posibleSums[j] + numbers[i]);
                countSum.Add(countSum[j] + 1);
            }
        }

        //As the two list are created simultaneously and hold the same amount of elements the index of the two are corresponding.
        for (int i = 0; i < posibleSums.Count; i++)
        {
            if (posibleSums[i] == sumS && countSum[i] == subsetK)
            {
                result = true;
            }
        }
        if (result)
        {
            Console.WriteLine("YES, there is sum {0} with {1} number from the array", sumS, subsetK);
        }
        else
        {
            Console.WriteLine("NO, there is no sum {0} with {1} number from the array", sumS, subsetK);
        }

    }
}


