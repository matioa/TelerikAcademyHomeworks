//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} numbers: ", N);
        int[] numbersN = new int[N];


        //Read the array
        for (int i = 0; i < N; i++)
        {
            numbersN[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array before sort: "+string.Join(",",numbersN));


        //Sort in ascending order the numbers in the array
        for (int checkNum = 0; checkNum < numbersN.Length; checkNum++)
        {
            for (int otherNum = checkNum + 1; otherNum < numbersN.Length; otherNum++)
            {
                if (numbersN[checkNum] > numbersN[otherNum])
                {
                    int tempNum = numbersN[otherNum];
                    numbersN[otherNum] = numbersN[checkNum];
                    numbersN[checkNum] = tempNum;
                }
            }
        }

        Console.WriteLine("Array after sort: "+string.Join(",", numbersN));
    }
}

