//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.

using System;

class Program
{
    static void Main()
    {
        //Console.Write("Enter number N: ");
        //int N = int.Parse(Console.ReadLine());
        int frequentNumber = 0;
        int counter = 1;
        int maxFrequency = 1;

        //Console.WriteLine("Enter {0} numbers: ", N);
        //int[] numbers = new int[N];


        ////Read the array
        //for (int i = 0; i < N; i++)
        //{
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //Find the most frequent number in the array
        for (int checkNum = 0; checkNum < numbers.Length; checkNum++)
        {
            if (numbers[checkNum] == frequentNumber)
            {
                continue;
            }

            for (int otherNum = checkNum+1; otherNum < numbers.Length; otherNum++)
            {
                if (numbers[checkNum] == numbers[otherNum])
                {
                    counter++;
                }
            }
            
            if (maxFrequency<counter)
            {
                maxFrequency = counter;
                frequentNumber = numbers[checkNum];
            }
            counter = 1;
        }

        //Print the result
        Console.WriteLine("{0} ({1} times)", frequentNumber,maxFrequency);
    }
}
