//Problem 4. Appearance count
//• Write a method that counts how many times given number appears in given array.
//• Write a test program to check if the method is workings correctly.


using System;
class AppearanceCount
{
    static void Main()
    {
        //Generate a random array
        Random randomGenerator = new Random();
        int[] sampleArray = new int[10];
        for (int i = 0; i < sampleArray.Length; i++)
        {
            sampleArray[i] = randomGenerator.Next(0, 10);
        }
        Console.WriteLine(string.Join(",",sampleArray));

        //Ask for an element in the array (or not in it) and count the number of apperances
        Console.Write("\nEnter number to be searched in the above array: ");
        int input = int.Parse(Console.ReadLine());
        int inputCount = CoutAppearances(input, sampleArray);
        Console.WriteLine("The number {0} appeared {1} times in the array", input, inputCount);
    }


    static int CoutAppearances(int searchNumber, int[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==searchNumber)
            {
                counter++;
            }
        }
        return counter;
    }
}

