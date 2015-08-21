//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [ 1...10 000 000 ]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine("Search prime numbers in the interval 2 - N:");
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        int counter = 0;

        //Create an array of bool elements with value true (we will consider all numbers above 2 to be prime as a start) (starting from index 2 onwards)
        bool[] primeNumbers = new bool[N + 1];
        for (int i = 2; i <= N; i++)
        {
            primeNumbers[i] = true;
        }

        //Check if the number is prime (starting from 2 we know is a prime number)
        for (int i = 2; i < Math.Sqrt(N); i++)
        {
            if (primeNumbers[i]==true)
            {
                //Mark all numbers that are multiples of i as false (not prime)
                int p = 0;
                for (int j = i*i; j <= N; j =i*i+p*i)
                {
                    primeNumbers[j] = false;
                    p++;
                }
            }
        }
        //Print only the indexes where the value is true (it is prime number)
        for (int i = 0; i <= N; i++)
        {
            if (primeNumbers[i]==true)
            {
                Console.Write(i);
                Console.Write(" ");
                counter++;
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("There are {0} prime numbers between 2 and {1}",counter,N);
        Console.WriteLine();
    }
}

