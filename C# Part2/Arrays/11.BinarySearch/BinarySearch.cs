//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        int[] numbers = Enumerable.Range(start, length).ToArray();
        Console.WriteLine(string.Join(",", numbers));

        Console.WriteLine("Enter number X to be searched: ");
        int X = int.Parse(Console.ReadLine());


        int min = 0;
        int middle = numbers.Length/2;
        int max = numbers.Length;

        while (true)
        {
            if (X == numbers[middle])
            {
                Console.WriteLine("Number {0} is on position {1}", X, middle);
                break;
            }
            else    if (X < numbers[middle])
            {
                max = middle;
                middle = (max - min) / 2 + min;
            }
            else
            {
                min = middle;
                middle = (max - min)/2 + min;
            }
        }

    }
}

