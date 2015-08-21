//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaxKSum
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter number K: ");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} numbers: ",N);
        int[] numbersN = new int[N];
        int[] numbersK = new int[K];
        int sum = 0;

        //Read the array
        for (int i = 0; i < N; i++)
        {
            numbersN[i] = int.Parse(Console.ReadLine());
        }

        //Sort in descending order the numbers in the array
        for (int checkNum = 0; checkNum < numbersN.Length; checkNum++)
        {
            for (int otherNum = checkNum+1; otherNum < numbersN.Length; otherNum++)
            {
                if (numbersN[checkNum] < numbersN[otherNum])
                {
                    int tempNum = numbersN[otherNum];
                    numbersN[otherNum] = numbersN[checkNum];
                    numbersN[checkNum] = tempNum;
                }
            }
        }

        //Sum the first K numbers in the array
        for (int i = 0; i < K; i++)
        {
            numbersK[i] = numbersN[i];
            sum += numbersN[i];
        }
        Console.WriteLine();
        Console.WriteLine(string.Join(",",numbersK));
        Console.WriteLine("The maximal sum is: {0}", sum); 
    }
}

