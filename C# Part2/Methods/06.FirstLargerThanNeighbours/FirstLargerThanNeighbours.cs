//Problem 6. First larger than neighbours
//• Write a method that returns the index of the first element in array that is larger than its neighbours, or  -1 , if there’s no such element.
//• Use the method from the previous exercise.


using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        //Generate a random array
        Random randomGenerator = new Random();
        int[] sampleArray = new int[15];
        for (int i = 0; i < sampleArray.Length; i++)
        {
            sampleArray[i] = randomGenerator.Next(-9, 10);
        }
        Console.WriteLine(string.Join(",", sampleArray));

        //Check each element of the array
        for (int i = 0; i < sampleArray.Length; i++)
        {
            if (GreaterThanNeighbours(i, sampleArray))
            {
                Console.WriteLine("\nFirst number greater than neighbours is {0} at position {1}", sampleArray[i], i);
                return;
            }
        }
        Console.WriteLine("-1");
    }

    static bool GreaterThanNeighbours(int elementPosition, int[] array)
    {
        if (elementPosition == 0)
        {
            if (array[elementPosition] > array[elementPosition + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (elementPosition == array.Length - 1)
        {
            if (array[elementPosition] > array[elementPosition - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (array[elementPosition] > array[elementPosition - 1] && array[elementPosition] > array[elementPosition + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

