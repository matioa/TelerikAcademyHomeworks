//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCirle
{
    static void Main()
    {
        Console.Write("Enter coordinate x:");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter coordinate y:");
        double pointY = double.Parse(Console.ReadLine());

        bool isInCirle = pointX*pointX + pointY*pointY < 2*2;
        Console.WriteLine("Point with x={0} and y={1} is in cirle? - {2}", pointX, pointY, isInCirle);
    }
}

