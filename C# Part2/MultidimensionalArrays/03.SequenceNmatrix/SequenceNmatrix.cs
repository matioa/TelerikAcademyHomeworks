//Problem 3. Sequence n matrix• 
//We are given a matrix of strings of size  N x M . Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//• Write a program that finds the longest sequence of equal strings in the matrix.


using System;

class SequenceNmatrix
{
    static void Main()
    {
        string[,] matrix = 
        {
            {"O","R","U","U"},
            {"M","U","Ha","Ha"},
            {"U","W","E","M"},
        };

        int bestSequence = 0;
        string bestString = "";

        //CHECK columns
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                //create temporary variables as in the while() we will increase their values
                int counter = 1;
                int rowTmp = row;
                int colTmp = col;

                //count all next strings if they are equal
                while (matrix[rowTmp, colTmp] == matrix[rowTmp, colTmp + 1])
                {
                    counter++;
                    colTmp++;
                    //break if outside the matrix
                    if ((colTmp + 1) >= matrix.GetLength(1))
                    {
                        break;
                    }
                }
                if (counter > bestSequence)
                {
                    bestSequence = counter;
                    bestString = matrix[row, col];
                }
            }
        }

        //CHECK rows
        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int counter = 1;
                int rowTmp = row;
                int colTmp = col;

                while (matrix[rowTmp, colTmp] == matrix[rowTmp + 1, colTmp])
                {
                    counter++;
                    rowTmp++;
                    if ((rowTmp + 1) >= matrix.GetLength(0))
                    {
                        break;
                    }
                }
                if (counter > bestSequence)
                {
                    bestSequence = counter;
                    bestString = matrix[row, col];
                }
            }
        }

        //CHECK right diagonals
        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int counter = 1;
                int rowTmp = row;
                int colTmp = col;

                while (matrix[rowTmp, colTmp] == matrix[rowTmp + 1, colTmp + 1])
                {
                    counter++;
                    colTmp++;
                    rowTmp++;
                    if ((rowTmp + 1) >= matrix.GetLength(0) || (colTmp + 1) >= matrix.GetLength(1))
                    {
                        break;
                    }
                }
                if (counter > bestSequence)
                {
                    bestSequence = counter;
                    bestString = matrix[row, col];
                }
            }
        }

        //CHECK left diagonals
        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                int counter = 1;
                int rowTmp = row;
                int colTmp = col;

                while (matrix[rowTmp, colTmp] == matrix[rowTmp + 1, colTmp - 1])
                {
                    counter++;
                    colTmp--;
                    rowTmp++;
                    if ((rowTmp + 1) >= matrix.GetLength(0) || (colTmp) < 0)
                    {
                        break;
                    }
                }
                if (counter > bestSequence)
                {
                    bestSequence = counter;
                    bestString = matrix[row, col];
                }
            }
        }

        //PRINT result
        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write("{0}, ",bestString);
        }
        Console.WriteLine();

    }
}

