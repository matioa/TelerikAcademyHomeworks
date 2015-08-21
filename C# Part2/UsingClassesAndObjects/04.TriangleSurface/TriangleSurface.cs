//Problem 4. Triangle surface
//• Write methods that calculate the surface of a triangle by given: ◦ Side and an altitude to it;
//◦ Three sides;
//◦ Two sides and an angle between them;

//• Use  System.Math .


using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Calculate triangle surface using:");
        Console.WriteLine("1. Side and altitude to it\n2. Three sides\n3. Two sides and an angle between them;");
        Console.Write("\nChoose an option: ");
        int userChoice = int.Parse(Console.ReadLine());
        double triangleArea = 0.0;

        switch (userChoice)
        {
            case 1: 
                Console.Write("Enter triangle side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude to the side: ");
                double altitude = double.Parse(Console.ReadLine());
                triangleArea = TriangleAreaStandard(side,altitude);
                Console.WriteLine("Triangle area = {0}", triangleArea);
                break;
            case 2:
                Console.Write("Enter triangle side a: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter triangle side b: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.Write("Enter triangle side c: ");
                double sideC = double.Parse(Console.ReadLine());
                triangleArea = TriangleAreaHeron(sideA,sideB,sideC);
                Console.WriteLine("Triangle area = {0}", triangleArea);
                break;
            case 3:
                Console.Write("Enter triangle side 1: ");
                decimal side1 = decimal.Parse(Console.ReadLine());
                Console.Write("Enter triangle side 2: ");
                decimal side2 = decimal.Parse(Console.ReadLine());
                Console.Write("Enter angle (degrees) between side a and b: ");
                int angle = int.Parse(Console.ReadLine());
                triangleArea = (double)TriangleAreaSAS(side1, side2, angle);
                Console.WriteLine("Triangle area = {0}", triangleArea);
                break;

            default: Console.WriteLine("You have entered an invalid choice");
                break;
        }

    }

    static double TriangleAreaStandard(double side, double altitude)
    {
        double area = (side * altitude) / 2;
        return area;
    }

    static double TriangleAreaHeron(double sideA, double sideB, double sideC)
    {
        double perimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        return area;
    }

    static decimal TriangleAreaSAS(decimal sideA, decimal sideB, int angleDegrees)
    {
        double angleRadians = angleDegrees / 57.2957795;
        decimal sin = (decimal)Math.Sin(angleRadians);
        decimal area = (sideA * sideB * sin) / 2;
        return area;
    }
}

