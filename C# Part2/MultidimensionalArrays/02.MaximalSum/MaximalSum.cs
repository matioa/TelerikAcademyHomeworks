//Problem 2. Maximal sum• 
//Write a program that reads a rectangular matrix of size  N x M  and finds in it the square  3 x 3  that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Random randomGenerator = new Random();

        Console.Write("Enter row number N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter column number M: ");
        int M = int.Parse(Console.ReadLine());

        //Generate random matrix
        int[,] matrix = new int[N, M];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = randomGenerator.Next(0, 10);
            }
        }

        //Draw the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //Restrict the search area for the starting cell of the square
        int bottomMargin = matrix.GetLength(0) - 2;
        int leftMargin = matrix.GetLength(1) - 2;
        int bestSum = int.MinValue;
        int bestRowIndex = 0;
        int bestColIndex = 0;

        //Check if the matrix is smaller than the square (3x3)
        if (bottomMargin == 0 || leftMargin == 0)
        {
            Console.WriteLine();
            Console.WriteLine("!!! Matrix is too small !!!");
            Console.WriteLine();
            return;
        }

        //Find the best suqare (3x3) int the matrix
        for (int row = 0; row < bottomMargin; row++)
        {
            for (int col = 0; col < leftMargin; col++)
            {
                int sum = matrix[row, col]
                        + matrix[row + 1, col]
                        + matrix[row + 2, col]
                        + matrix[row, col + 1]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 2, col + 1]
                        + matrix[row, col + 2]
                        + matrix[row + 1, col + 2]
                        + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRowIndex = row;
                    bestColIndex = col;
                }
            }
        }

        //Draw the square
        Console.WriteLine();
        Console.WriteLine("Best square is:");
        for (int row = bestRowIndex; row < bestRowIndex + 3; row++)
        {
            for (int col = bestColIndex; col < bestColIndex + 3; col++)
            {
                Console.Write("{0,-3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Best sum is {0}", bestSum);
        Console.WriteLine();

    }


}

