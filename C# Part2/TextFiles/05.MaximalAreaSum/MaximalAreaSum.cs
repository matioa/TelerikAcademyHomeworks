//Problem 5. Maximal area sum
//    Write a program that reads a text file containing a square matrix of numbers.
//    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//        The first line in the input file contains the size of matrix N.
//        Each of the next N lines contain N numbers separated by space.
//        The output should be a single number in a separate text file.

using System;
using System.IO;
using System.Linq;

class MaximalAreaSum
{
    static void Main()
    {
        var matrix = ReadInput();
        int platformRows = 2;
        int platformCols = 2;
        int maxSum = FindMaxAreaInMatirx(matrix, platformRows, platformCols);

        StreamWriter writer = new StreamWriter(@"../../Output.txt");
        using (writer)
        {
            writer.WriteLine(maxSum);
        }
        Console.WriteLine("File generated.");

    }
    static int[,] ReadInput()
    {
        StreamReader reader = new StreamReader(@"../../Input.txt");
        int matrixSize = int.Parse(reader.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        using (reader)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                string currentRowAsText = reader.ReadLine();
                char[] splitter = { ' ' };
                int[] currentRowAsNum = currentRowAsText.Split(splitter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < currentRowAsNum.Length; col++)
                {
                    matrix[row, col] = currentRowAsNum[col];
                }
            }
        }
        return matrix;
    }

    static int FindMaxAreaInMatirx(int[,] matrix, int platformRows, int platformCols)
    {
        int maxSum = int.MinValue;

        for (int row = 0; row < (matrix.GetLength(0) - platformRows + 1); row++)
        {
            for (int col = 0; col < (matrix.GetLength(1) - platformCols + 1); col++)
            {
                int currentPlatformSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (maxSum < currentPlatformSum)
                {
                    maxSum = currentPlatformSum;
                }
            }
        }

        return maxSum;
    }
}


