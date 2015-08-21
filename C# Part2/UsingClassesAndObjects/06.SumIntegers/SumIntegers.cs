//Problem 6. Sum integers
//• You are given a sequence of positive integer values written into a string, separated by spaces.
//• Write a function that reads these values from given string and calculates their sum.


using System;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of positive integer values separated by spaces: ");
        string input = Console.ReadLine();
        string[] numbersAsText = input.Split(' ');
        int[] numbers = new int[numbersAsText.Length];
        long sum = 0;
        for (int i = 0; i < numbersAsText.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsText[i]);
            sum += numbers[i];
        }
        Console.WriteLine(string.Join(" + ",numbers)+" = {0}",sum);

    }
}

