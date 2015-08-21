//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Check if given number is prime or not.");
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());

        if (number > 1)
        {
	        bool isDivByOtherNumbers = new bool();
            bool isNotPrime = new bool();
	        for (int i=2;i<=Math.Sqrt(number);i++)
	        {
                isDivByOtherNumbers = number % i == 0;
                if (isDivByOtherNumbers)
                {
                    isNotPrime = isDivByOtherNumbers;
                }
}
	        if (isNotPrime)
	        {
		        Console.WriteLine("Result: Not Prime");
	        } else
	        {
		        Console.WriteLine("Result: Prime");
	        }
        } else
        {
	        Console.WriteLine("Result: Not Prime");
        }
    }
}
