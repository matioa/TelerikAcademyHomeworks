//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Calculate trapezoid's area by given sides 'a' and 'b' and height 'h'");
        Console.Write("Enter side 'a': ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter side 'b': ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter height 'h': ");
        float h = float.Parse(Console.ReadLine());

        double area = ((a + b) * h) / 2;
        Console.WriteLine("   a |   b |   h | area");
        Console.WriteLine("{0,4} |{1,4} |{2,4} |{3,4}", a, b, h, area);
    }
}
