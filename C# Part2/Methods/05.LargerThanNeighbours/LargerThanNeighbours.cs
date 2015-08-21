//Problem 5. 
//Larger than neighbours• Write a method that checks if the element at given position in given array of integers 
//is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        //Generate a random array
        Random randomGenerator = new Random();
        int[] sampleArray = new int[15];
        for (int i = 0; i < sampleArray.Length; i++)
        {
            sampleArray[i] = randomGenerator.Next(0, 10);
        }
        Console.WriteLine(string.Join(",", sampleArray));

        //Ask for element position to be checked and check it
        Console.Write("\nEnter element position to be compared to its neighbours: ");
        int input = int.Parse(Console.ReadLine());
        bool result = GreaterThanNeighbours(input, sampleArray);
        Console.WriteLine("Is number {0} at position {1} greater than its neighbours? {2}", sampleArray[input], input, result);

    }

    static bool GreaterThanNeighbours(int elementPosition, int[] array)
    {
        if (elementPosition == 0)
        {
            if (array[elementPosition] > array[elementPosition + 1])
            {
                return  true;
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

