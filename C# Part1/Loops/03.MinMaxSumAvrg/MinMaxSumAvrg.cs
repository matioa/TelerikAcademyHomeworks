//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

    class MinMaxSumAvrg
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int numberMin = 0;
            int numberMax = 0;
            int numberSum = 0;
            double numberAvrg = 0;

            for (int i=1; i<=n; i++)
            {
	            int userInput = int.Parse(Console.ReadLine());
	            if(i ==1)
	            {
		            numberMin = userInput;
		            numberMax = userInput;
		            numberSum = userInput;
	            } else
	            {
		            numberMin = Math.Min(numberMin, userInput);
		            numberMax = Math.Max(numberMax, userInput);
                    numberSum += userInput;
	            }
            }
            numberAvrg = (double)(numberSum) / n;
            Console.WriteLine("min = {0}",numberMin);
            Console.WriteLine("max = {0}",numberMax);
            Console.WriteLine("sum = {0}",numberSum);
            Console.WriteLine("avg = {0:F2}",numberAvrg);
        }
    }

