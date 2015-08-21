//Problem 11. Adding polynomials
//• Write a method that adds two polynomials.
//• Represent them as arrays of their coefficients.


using System;

class AddingPolynomials
{
    static void Main()
    {
        // index 0 is the constant, index 1 the power of 1, index 2 of 2, etc... 
        int[] polCoef1 = { 5, 0, 1 };
        int[] polCoef2 = { 0, 9, 4 };

        PrintPolynomials(polCoef1);
        Console.WriteLine("\n+");
        PrintPolynomials(polCoef2);
        Console.WriteLine("\n=");
        int[] addPolynomials = AddPolynomials(polCoef1, polCoef2);
        PrintPolynomials(addPolynomials);
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

