//Problem 1. 
//Fill the matrix• Write a program that fills and prints a matrix of size  (n, n)  as shown below:


using System;

class FillTheMatrix
{
    static void Main()
    {
        //CHANGE number to change the size of all 4 Matrices
        int allMatrixSizes = 4;

        //================================================
        #region Draw Matrix a
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Matrix a)");
        Console.WriteLine();

        int[,] matrixA = new int[allMatrixSizes, allMatrixSizes];
        int cellValue = 1;

        for (int column = 0; column < matrixA.GetLength(0); column++)
        {
            for (int row = 0; row < matrixA.GetLength(1); row++)
            {
                matrixA[row, column] = cellValue;
                cellValue++;
            }
        }

        //Draw the matrix
        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matrixA[row, col]);
            }
            Console.WriteLine();
        }
#endregion

        //================================================
        #region Draw Matrix b
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Matrix b)");
        Console.WriteLine();

        int[,] matrixB = new int[allMatrixSizes, allMatrixSizes];
        cellValue = 1;

        for (int column = 0; column < matrixB.GetLength(1); column++)
        {
            if (column % 2 == 0)
            {
                for (int row = 0; row < matrixB.GetLength(0); row++)
                {
                    matrixB[row, column] = cellValue;
                    cellValue++;
                }
            }
            else
            {
                for (int row = matrixB.GetLength(1) - 1; row >= 0; row--)
                {
                    matrixB[row, column] = cellValue;
                    cellValue++;
                }
            }
        }
        //Draw the matrix
        for (int row = 0; row < matrixB.GetLength(0); row++)
        {
            for (int col = 0; col < matrixB.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matrixB[row, col]);
            }
            Console.WriteLine();
        }
#endregion

        //==================================================
        #region Draw Matrix c
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Matrix c)");
        Console.WriteLine();

        int[,] matrixC = new int[allMatrixSizes, allMatrixSizes];
        cellValue = 1;

        //Start from bottom left and go up and rith
        for (int row = matrixC.GetLength(0); row >= 0; row--)
        {
            int col = 0;
            int rowTmp = row;
            while (rowTmp < matrixC.GetLength(0))
            {
                matrixC[rowTmp, col] = cellValue;
                rowTmp++;
                col++;
                cellValue++;
            }
        }

        //Start from top left and go down and right
        for (int col = 1; col < matrixC.GetLength(1); col++)
        {
            int row = 0;
            int colTmp = col;
            while (colTmp < matrixC.GetLength(1))
            {
                matrixC[row, colTmp] = cellValue;
                row++;
                colTmp++;
                cellValue++;
            }
        }


        //Draw the matrix
        for (int row = 0; row < matrixC.GetLength(0); row++)
        {
            for (int col = 0; col < matrixC.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matrixC[row, col]);
            }
            Console.WriteLine();
        }
#endregion

        //==================================================
        #region Draw matrixA D
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Matrix d)");
        Console.WriteLine();

        int[,] matrixD = new int[allMatrixSizes, allMatrixSizes];
        cellValue = 1;

        bool goLeft = false;
        bool goRight = false;
        bool goUp = false;
        bool goDown = true;
        int leftCol = 0;
        int rightCol = matrixD.GetLength(1);
        int topRow = 0;
        int bottomRow = matrixD.GetLength(0);
        int rowD = 0;
        int colD = 0;

        while (topRow != bottomRow || leftCol != rightCol)
        {
            if (goDown)
            {
                for (int row = topRow; row < bottomRow; row++)
                {
                    rowD = row;
                    matrixD[rowD, colD] = cellValue;
                    cellValue++;
                }
                leftCol++;
                goDown = false;
                goRight = true;
            }

            if (goRight)
            {
                for (int col = leftCol; col < rightCol; col++)
                {
                    colD = col;
                    matrixD[rowD, colD] = cellValue;
                    cellValue++;
                }
                bottomRow--;
                goRight = false;
                goUp = true;
            }

            if (goUp)
            {
                for (int row = bottomRow - 1; row >= topRow; row--)
                {
                    rowD = row;
                    matrixD[rowD, colD] = cellValue;
                    cellValue++;
                }
                rightCol--;
                goUp = false;
                goLeft = true;
            }

            if (goLeft)
            {
                for (int col = rightCol - 1; col >= leftCol; col--)
                {
                    colD = col;
                    matrixD[rowD, colD] = cellValue;
                    cellValue++;
                }
                topRow++;
                goLeft = false;
                goDown = true;
            }

        }
        //Draw the matrix
        for (int row = 0; row < matrixD.GetLength(0); row++)
        {
            for (int col = 0; col < matrixD.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matrixD[row, col]);
            }
            Console.WriteLine();
        }
        #endregion
    }
}

