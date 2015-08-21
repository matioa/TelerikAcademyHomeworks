//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        Console.Write("Enter point x: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Enter point y: ");
        float y = float.Parse(Console.ReadLine());

        bool inCirle = (x-1)*(x-1) + (y-1)*(y-1) <= 1.5*1.5;
        bool inRectangle = (-1 <= y && y <= 1) && (-1 <= x && x <= 5);

        if (inCirle & !inRectangle)
        {
	        Console.WriteLine("inside K & outside R? Yes");
            Console.WriteLine();
        } else
        {
            Console.WriteLine("inside K & outside R? No");
            Console.WriteLine();
        }
    }
}
