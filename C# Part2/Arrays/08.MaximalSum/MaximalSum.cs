//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main()
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int bestSum = int.MinValue;
        int startIndex = 0;
        int endIndex = 0;

        //Find the best sum by comparing all result with best bestSum and saving startIndex and endIndex for the bestSum
        for (int i = 0; i < numbers.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                sum += numbers[j];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    startIndex = i;
                    endIndex = j;
                }
            }
        }
        //Print the result
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(numbers[i]);
            Console.Write(",");
        }
        Console.WriteLine();
    }
}

