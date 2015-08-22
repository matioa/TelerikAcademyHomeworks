using System;

namespace Task3
{
    class WalkInmatrix
    {
        private static void goToNextCell(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            // check current direction
            for (int i = 0; i < 8; i++)
            {
                if (dirX[i] == dx && dirY[i] == dy)
                {
                    cd = i;
                    break;
                }
            }

            // if this is the last move, start from the first move again
            if (cd == 7)
            {
                dx = dirX[0];
                dy = dirY[0];
                return;
            }

            // go to next cell
            dx = dirX[cd + 1];
            dy = dirY[cd + 1];
        }

        private static bool AjdacentCellIsZero(int[,] arr, int x, int y)
        {
            // initializes all possible move values
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            // if some of the adjacent cells are not existing - change the move value to 0 so that not to go to this cell.
            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            // check if at least one of the adjacent cells is equal to 0
            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void find_cell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)

                for (int j = 0; j < arr.GetLength(0); j++)
                    if (arr[i, j] == 0) { x = i; y = j; return; }

        }

        private static void Main()
        {
            int matrixSize = 3;
            int[,] matrix = new int[matrixSize, matrixSize];
            int step = matrixSize;
            int currentValue = 1;
            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 1;

            while (true)
            { //malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[row, col] = currentValue;

                if (!AjdacentCellIsZero(matrix, row, col))
                {
                    break;
                }

                bool rowOutOfRange = row + dx >= matrixSize || row + dx < 0;
                bool colOutOfRange = col + dy >= matrixSize || col + dy < 0;
                bool cellIsFilled = matrix[row + dx, col + dy] != 0;

                if (rowOutOfRange || colOutOfRange || cellIsFilled)
                {
                    while (rowOutOfRange || colOutOfRange || cellIsFilled)
                    {
                        goToNextCell(ref dx, ref dy);
                    }
                }

                row += dx;
                col += dy;
                currentValue++;
            }

            for (int p = 0; p < matrixSize; p++)
            {
                for (int q = 0; q < matrixSize; q++) Console.Write("{0,3}", matrix[p, q]);
                Console.WriteLine();
            }

            find_cell(matrix, out row, out col);
            if (i != 0 && j != 0)
            { // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                dx = 1; dy = 1;


                while (true)
                { //malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[i, j] = currentValue;
                    if (!AjdacentCellIsZero(matrix, i, j)) { break; }// prekusvame ako sme se zadunili
                    if (i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0)


                        while ((i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0)) change(ref dx, ref dy);
                    i += dx; j += dy; currentValue++;
                }
            }
            for (int pp = 0; pp < n; pp++)
            {
                for (int qq = 0; qq < n; qq++) Console.Write("{0,3}", matrix[pp, qq]);

                Console.WriteLine();
            }
        }
    }
}

