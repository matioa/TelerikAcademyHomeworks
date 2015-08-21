//21.Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
using System;
class Combinations
{
    static int k, n;
    static int[] array;

    public static void combinations(int firstIndex, int firstNumber)
    {
        if (firstIndex == k)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = firstNumber; i <= n; i++)
            {
                array[firstIndex] = i;
                combinations(firstIndex + 1, i + 1);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter elements N=");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter numbers K=");
        k = int.Parse(Console.ReadLine());
        array = new int[k];
        combinations(0, 1);
    }
}