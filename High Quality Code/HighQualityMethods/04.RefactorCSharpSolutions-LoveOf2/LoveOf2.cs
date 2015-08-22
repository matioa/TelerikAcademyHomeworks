using System;
using System.Numerics;
using System.Linq;
using System.IO;

class LoveOfTwo
{
    private static int Rows;
    private static int Columns;
    private static int moves;

    static void Main()
    {
        // Read input
        Rows = int.Parse(Console.ReadLine());
        Columns = int.Parse(Console.ReadLine());
        moves = int.Parse(Console.ReadLine());
        int[] codedMoves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int codeKey = Math.Max(Rows, Columns);
        int[] allPositionsRows = DecodePositionRows(codedMoves, codeKey);
        int[] allPositionsCols = DecodePositionCols(codedMoves, codeKey);

        // Initial state
        BigInteger[,] matrix = CreateMatrix(Rows, Columns);
        int currentRow = Rows - 1;
        int currentCol = 0;
        BigInteger points = matrix[currentRow, currentCol];
        matrix[currentRow, currentCol] = 0;

        // Start collecting points
        for (int i = 0; i < allPositionsRows.Length; i++)
        {
            int nextRow = allPositionsRows[i];
            int nextCol = allPositionsCols[i];

            points += CollectPoints(matrix, currentRow, currentCol, nextRow, nextCol);
            currentRow = nextRow;
            currentCol = nextCol;
        }

        Console.WriteLine(points);
    }

    private static BigInteger CollectPoints(BigInteger[,] matrix, int currentRow, int currentCol, int targetRow, int targetCol)
    {
        BigInteger points = 0;
        int rowMoves = Math.Abs(targetRow - currentRow);
        int colMoves = Math.Abs(targetCol - currentCol);

        for (int moveRow = 0; moveRow < rowMoves; moveRow++)
        {
            if (targetRow - currentRow < 0)
            {
                currentRow--;
            }
            else
            {
                currentRow++;
            }
            points += matrix[currentRow, currentCol];
            matrix[currentRow, currentCol] = 0;
        }

        for (int moveCol = 0; moveCol < colMoves; moveCol++)
        {
            if (targetCol - currentCol < 0)
            {
                currentCol--;
            }
            else
            {
                currentCol++;
            }
            points += matrix[currentRow, currentCol];
            matrix[currentRow, currentCol] = 0;
        }
        return points;
    }

    private static BigInteger[,] CreateMatrix(int Rows, int Cols)
    {
        BigInteger[,] matrix = new BigInteger[Rows, Cols];

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int rowPower = matrix.GetLength(0) - row - 1;
                int colPower = col;

                if (row == Rows - 1 && col == 0)
                {
                    matrix[row, col] = 1;
                }
                else if (row == Rows - 1)
                {
                    matrix[row, col] = (BigInteger)Math.Pow(2, colPower);
                }
                else if (col == 0)
                {
                    matrix[row, col] = (BigInteger)Math.Pow(2, rowPower);
                }
                else
                {
                    matrix[row, col] = matrix[row, col - 1] + matrix[row + 1, col];
                }
            }
        }
        return matrix;
    }

    private static int[] DecodePositionCols(int[] allPositionsCoded, int codeKey)
    {
        int[] allPositionsCols = new int[allPositionsCoded.Length];
        for (int i = 0; i < allPositionsCoded.Length; i++)
        {
            allPositionsCols[i] = allPositionsCoded[i] % codeKey;
        }
        return allPositionsCols;
    }

    private static int[] DecodePositionRows(int[] allPositionsCoded, int codeKey)
    {
        int[] allPositionsRows = new int[allPositionsCoded.Length];
        for (int i = 0; i < allPositionsCoded.Length; i++)
        {
            allPositionsRows[i] = allPositionsCoded[i] / codeKey;
        }

        return allPositionsRows;
    }

}