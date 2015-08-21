//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c: ");
        float c = float.Parse(Console.ReadLine());
        float num1;
        float num2;
        float num3;

        if ( a > b)
        {
	        if (a > c)
	        {
		        num1 = a;
		        if ( b > c)
		        {
			        num2 = b;
			        num3 = c;
		        } else
		        {
			        num2 = c;
			        num3 = b;
		        }
	        } else
	        {
		        num1 = c;
		        num2 = a;
		        num3 = b;
	        }
        } else if (b > c)
        {
	        num1 = b;
	        if (a > c)
	        { 
		        num2 = a;
		        num3 = c;
	        } else
	        {
		        num2 = c;
		        num3 = a;
	        }
        } else
        {
	        num1 = c;
	        num2 = b;
	        num3 = a;
        }
Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", num1, num2, num3);
    }
}

