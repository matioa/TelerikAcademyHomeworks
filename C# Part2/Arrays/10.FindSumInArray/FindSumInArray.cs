//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers: ", N);
        int[] numbers = new int[N];
        int counter = 0;
        bool printIt = false;

        //Read the array
        for (int i = 0; i < N; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Enter searching sum S
        Console.Write("Enter sum S: ");
        int S = int.Parse(Console.ReadLine());

        //Loop through all the sequences starting with each of the digits in the array
        for (int i = 0; i < numbers.Length; i++)
        {
            int sum = S;
            for (int j = i; j < numbers.Length; j++)
			{
                sum -= numbers[j];
                counter++;
                if (sum == 0)
                {
                    printIt = true;
                    break;
                }
                if (sum <0)
                {
                    break;
                }
			}
            if (printIt)
            {
                for (int k = i; k < i+counter; k++)
                {
                    Console.Write("{0},",numbers[k]);
                }
                Console.WriteLine();
            }
            //Zero the temporary variables for the next loop
            counter = 0;
            printIt = false;
        }
            
    }
}
