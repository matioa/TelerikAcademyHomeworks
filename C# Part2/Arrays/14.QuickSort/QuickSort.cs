//Problem 14. Quick sort
//Write a program that sorts an array of integers using the Quick sort algorithm.


using System;

class Program
{
    static void Main()
    {
        // Create an unsorted array of integers
        int[] unsorted = { 101, 3, -62, 45, 3, 5, 7,-4, 23, 5, 7 , 1, 88, 100};

        // Print the unsorted array
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();

        // Sort the array
        Quicksort(unsorted, 0, unsorted.Length - 1);

        // Print the sorted array
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();
    }

    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = left/2 + right/2;

        while (i <= j)
        {
            while (elements[i] < elements[pivot])
            {
                i++;
            }

            while (elements[j] > elements[pivot])
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                int temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }

}

