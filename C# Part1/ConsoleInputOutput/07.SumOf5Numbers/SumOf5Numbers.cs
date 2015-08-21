//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers separated with spaces: ");
        string userInput = (Console.ReadLine()).Trim();     // remove possible spaces in the begining and the end of the entered numbers
        int nextSpace = 0;
        int prevSpace = 0;

        nextSpace = userInput.IndexOf(" ");
        float num1 = float.Parse(userInput.Substring(prevSpace, nextSpace - prevSpace));
        userInput = userInput.Substring(nextSpace + 1);

        nextSpace = userInput.IndexOf(" ");
        float num2 = float.Parse(userInput.Substring(prevSpace, nextSpace - prevSpace));
        userInput = userInput.Substring(nextSpace + 1);

        nextSpace = userInput.IndexOf(" ");
        float num3 = float.Parse(userInput.Substring(prevSpace, nextSpace - prevSpace));
        userInput = userInput.Substring(nextSpace + 1);

        nextSpace = userInput.IndexOf(" ");
        float num4 = float.Parse(userInput.Substring(prevSpace, nextSpace - prevSpace));
        userInput = userInput.Substring(nextSpace + 1);

        float num5 = float.Parse(userInput.Substring(prevSpace));

        float sum = num1 + num2 + num3 + num4 + num5;

        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", num1, num2, num3, num4, num5, sum);
    }
}

