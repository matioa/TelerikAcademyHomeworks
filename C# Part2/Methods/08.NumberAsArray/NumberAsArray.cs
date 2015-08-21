//Problem 8. Number as array
//• Write a method that adds two positive integer numbers represented as arrays of digits (each array element  arr[i]  contains a digit; the last digit is kept in  arr[0] ).
//• Each of the numbers that will be added could have up to  10 000  digits.

using System;

class NumberAsArray
{
    static void Main()
    {
        //Generate two random arrays
        Random randomGenerator = new Random();
        int[] numArray1 = new int[randomGenerator.Next(1, 7)];
        int[] numArray2 = new int[randomGenerator.Next(1, 7)];
        for (int i = 0; i < numArray1.Length; i++)
        {
            numArray1[i] = randomGenerator.Next(0, 10);
        }
        for (int i = 0; i < numArray2.Length; i++)
        {
            numArray2[i] = randomGenerator.Next(0, 10);
        }

        //Add arrays to a new array
        int[] sumArrays = AddNumberArrays(numArray1, numArray2);

        Console.Write("Array 1: ");
        Console.WriteLine(string.Join("", numArray1));
        Console.Write("Array 2: ");
        Console.WriteLine(string.Join("", numArray2));
        Console.WriteLine();

        Console.WriteLine(string.Join("", ReverseDigits(numArray1)));
        Console.WriteLine("+");
        Console.WriteLine(string.Join("", ReverseDigits(numArray2)));
        Console.WriteLine("=");
        Console.WriteLine(string.Join("", ReverseDigits(sumArrays)));

    }

    static int[] AddNumberArrays(int[] array1, int[] array2)
    {
        int minLenght = Math.Min(array1.Length, array2.Length);
        int maxLenght = Math.Max(array1.Length, array2.Length);
        int[] smallerArray = new int[minLenght];
        int[] biggerArray = new int[maxLenght];
        int addNumber = 0;
        int[] result = new int[maxLenght + 1];

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

        //Start filling the result array with figures up to the smaller array length.
        for (int i = 0; i < smallerArray.Length; i++)
        {
            int sum = 0;
            sum = smallerArray[i] + biggerArray[i] + addNumber;
            if (sum <= 9)
            {
                result[i] = sum;
                addNumber = 0;
            }
            else
            {
                result[i] = sum % 10;
                addNumber = 1;
            }
        }

        //Add the additional elements from the bigger array only
        for (int i = smallerArray.Length; i < biggerArray.Length; i++)
        {
            int sum = 0;
            sum = biggerArray[i] + addNumber;
            if (sum <= 9)
            {
                result[i] = sum;
                addNumber = 0;
            }
            else
            {
                result[i] = sum % 10;
                addNumber = 1;
            }
        }

        //Check if we have to add 1 or not to the last element of the new array
        if (addNumber > 0)
        {
            result[biggerArray.Length + 1] = addNumber;
        }
        return result;
    }

    static int[] ReverseDigits(int[] digits)
    {
        int[] reverseDigits = new int[digits.Length];
        int counter = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            reverseDigits[counter] = digits[i];
            counter++;
        }
        return reverseDigits;
    }

}

