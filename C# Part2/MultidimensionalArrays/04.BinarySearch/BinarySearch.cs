//Problem 4. Binary search• 
//Write a program, that reads from the console an array of  N  integers and an integer  K , sorts the array 
//and using the method  Array.BinSearch()  finds the largest number in the array which is ≤  K . 


using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        Console.WriteLine("Enter {0} numbers:",N);
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number K to be serched: ");
        int k = int.Parse(Console.ReadLine());

        //Print origianl array
        Console.Write("Original array: ");
        Console.WriteLine(string.Join(",",array));

        //Sort the array
        Array.Sort(array);

        //Print sorted array
        Console.Write("Sorted array: ");
        Console.WriteLine(string.Join(",", array));
        Console.WriteLine();

        int index = Array.BinarySearch(array, k);
        if (index<0)
        {
            if (-index-2<0)
            {
                Console.WriteLine("There is not integer in the array that is <= {0}",k);
            }
            else
            {
                Console.WriteLine("The nearest number that is <={0} is {1} on position {2}", k, array[-index - 2], -index - 2);
            }
        }
        else
        {
            Console.WriteLine("Searched number {0} is on position {1}",k,index);
        }
    }
}

