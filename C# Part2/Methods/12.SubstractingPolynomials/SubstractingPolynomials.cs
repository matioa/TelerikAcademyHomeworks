//Problem 12. Subtracting polynomials
//• Extend the previous program to support also subtraction and multiplication of polynomials.


using System;

class Program
{
    static void Main()
    {
        // index 0 is the constant, index 1 the power of 1, index 2 of 2, etc... 
        int[] polCoef1 = { 5, 0, 1 };
        int[] polCoef2 = { 0, 9, 4 };

        PrintPolynomials(polCoef1);
        Console.WriteLine("\n-");
        PrintPolynomials(polCoef2);
        Console.WriteLine("\n=");
        int[] subsPolynomials = SubstactPolynomials(polCoef1, polCoef2);
        PrintPolynomials(subsPolynomials);
        Console.WriteLine();

        Console.WriteLine("\n\n");
        PrintPolynomials(polCoef1);
        Console.WriteLine("\n*");
        PrintPolynomials(polCoef2);
        Console.WriteLine("\n=");
        int[] multPolynomials = MultiplyPolynomials(polCoef1, polCoef2);
        PrintPolynomials(multPolynomials);
        Console.WriteLine();

    }
    static int[] AddPolynomials(int[] array1, int[] array2)
    {
        int minLenght = Math.Min(array1.Length, array2.Length);
        int maxLenght = Math.Max(array1.Length, array2.Length);
        int[] smallerArray = new int[minLenght];
        int[] biggerArray = new int[maxLenght];

        int[] result = new int[maxLenght];

        //Find out which array is smaller
        if (array1.Length > array2.Length)
        {
            biggerArray = array1;
            smallerArray = array2;
        }
        else
        {
            biggerArray = array2;
            smallerArray = array1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = smallerArray[i] + biggerArray[i];
        }
        for (int i = minLenght; i < maxLenght; i++)
        {
            result[i] = biggerArray[i];
        }
        return result;
    }

    static int[] SubstactPolynomials(int[] array1, int[] array2)
    {
        int minLenght = Math.Min(array1.Length, array2.Length);
        int maxLenght = Math.Max(array1.Length, array2.Length);

        int[] result = new int[maxLenght];


        if (array1.Length == maxLenght)
        {
            for (int i = 0; i < minLenght; i++)
            {
                result[i] = array1[i] - array2[i];
            }
            for (int i = minLenght; i < maxLenght; i++)
            {
                result[i] = array1[i];
            }
        }
        else
        {
            for (int i = 0; i < minLenght; i++)
            {
                result[i] = array1[i] - array2[i];
            }
            for (int i = minLenght; i < maxLenght; i++)
            {
                result[i] = -array1[i];
            }
        }

        return result;
    }

    static int[] MultiplyPolynomials(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length - 1];

        for (int id1 = 0; id1 < array1.Length; id1++)
        {
            for (int id2 = 0; id2 < array1.Length; id2++)
            {
                result[id1 + id2] += (array1[id1] * array1[id2]);
            }
        }
        return result;
    }


    public static void PrintPolynomials(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write("{0}*x^{1}", array[i], i);
            }
            else
            {
                Console.Write("{0}*x^{1}+", array[i], i);
            }
        }
    }
}

