//Problem 9. Sorting array
//• Write a method that return the maximal element in a portion of array of integers starting at given index.
//• Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
{
    static void Main()
    {
        int[] sampleArray = { 3, 5, 2, 87, 44, 7, 89, 88, 88, 45 };
        int[] sortedArray = new int[sampleArray.Length];

        Console.WriteLine("Unsorted");
        Console.WriteLine(string.Join(",", sampleArray));
        Console.WriteLine();
        
        sortedArray = SortArray(sampleArray);
        Console.WriteLine("Sorted Ascending");
        Console.WriteLine(string.Join(",", sortedArray));
        Console.WriteLine();

        sortedArray = SortArrayDescending(sampleArray);
        Console.WriteLine("Sorted Descending");
        Console.WriteLine(string.Join(",", sortedArray));
    }

    static int FindMaxElement(int[] array, int startIndex)
    {
        int maxElement = int.MinValue;
        int maxElementPosition = 0;
        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxElementPosition = i;
            }
        }
        return maxElementPosition;
    }
    static int FindMaxElement(int[] array, int startIndex, int endIndex)
    {
        int maxElement = int.MinValue;
        int maxElementPosition = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxElementPosition = i;
            }
        }
        return maxElementPosition;
    }

    static int[] SortArray(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int positionMaxElement = FindMaxElement(array, 0, i);
            int temp = array[i];
            array[i] = array[positionMaxElement];
            array[positionMaxElement] = temp;
        }
        return array;
    }
    static int[] SortArrayDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int positionMaxElement = FindMaxElement(array, i);
            int temp = array[i];
            array[i] = array[positionMaxElement];
            array[positionMaxElement] = temp;
        }
        return array;
    }
}

