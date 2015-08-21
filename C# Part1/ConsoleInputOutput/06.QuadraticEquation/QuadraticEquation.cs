//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter constant a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter constant b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter constant c: ");
        float c = float.Parse(Console.ReadLine());

        double discriminant = b*b - 4*a*c;
        if (discriminant == 0)
        {
	        Console.WriteLine("There is one root x={0}",-b/(2*a));
        } else if (discriminant >0)
        {
        	double rootX1= (-b+Math.Sqrt(discriminant))/(2*a);
          	double rootX2= (-b-Math.Sqrt(discriminant))/(2*a);
        	Console.WriteLine("There are two real roots: x1={0}, x2={1}", rootX1, rootX2);
        } else
        {	
        	Console.WriteLine("There are no real roots.");
        }
    }
}

