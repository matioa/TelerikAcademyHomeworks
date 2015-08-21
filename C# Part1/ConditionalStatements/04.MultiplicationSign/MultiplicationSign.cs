//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c: ");
        float c = float.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        } else if ( (a < 0 && b > 0 && c > 0) ||
			        (a > 0 && b < 0 && c > 0) ||
			        (a > 0 && b > 0 && c < 0) ||
			        (a < 0 && b < 0 && c < 0))
        {
	        Console.WriteLine("-");			
        } else
        {
	        Console.WriteLine("+");
        }
    }
}

