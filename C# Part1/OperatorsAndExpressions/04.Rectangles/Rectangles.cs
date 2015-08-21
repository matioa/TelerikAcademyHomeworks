//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Calculates rectangle’s perimeter and area by given width and height.");
        Console.Write("Enter width:");
        float width = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter height:");

        float height = Convert.ToSingle(Console.ReadLine());
        double perimeter = (width + height) * 2;
        double area = width * height;

        Console.WriteLine();
        Console.WriteLine("widht | height | perimeter | area");
        Console.WriteLine("{0,5} | {1,6} | {2,9} | {3,4}",width, height, perimeter, area);
        Console.WriteLine();
    }
}
