//Problem 5. Sort by string length• 
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int N = int.Parse(Console.ReadLine());
        string[] array = new string[N];
        Console.WriteLine("Enter {0} words:",N);
        for (int i = 0; i < N; i++)
        {
            array[i] = Console.ReadLine();
        }

        string[] sortedArray = SortArray(array);

        Console.WriteLine(new string('=',30));
        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.WriteLine(sortedArray[i]);
        }
        Console.WriteLine();

    }

    static string[] SortArray(string[] arrayToSort)
    {
        string[] sortedArray = arrayToSort.OrderBy(s => s.Length).ToArray();
        return sortedArray;
    }
}

