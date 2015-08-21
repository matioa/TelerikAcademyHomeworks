//Problem 2. Get largest number
//• Write a method  GetMax()  with two parameters that returns the larger of two integers.
//• Write a program that reads  3  integers from the console and prints the largest of them using the method  GetMax() .

using System;

class GetLargetsNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int bigestnumber = 0;

        bigestnumber = GetMax(num1, num2);
        bigestnumber = GetMax(bigestnumber, num3);
        Console.WriteLine();
        Console.WriteLine("The biggest number is {0}", bigestnumber);

    }

    static int GetMax(int a, int b)
    {
        if (a>b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}

