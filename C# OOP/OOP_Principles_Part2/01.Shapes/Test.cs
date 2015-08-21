using System;
using System.Collections.Generic;

namespace _01.Shapes
{
    class Test
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            Shape oneSquare = new Square(5);
            Shape anotherSquare = new Square(7);
            Shape oneRectangle = new Rectangle(3, 4);
            Shape anotherRectangle = new Rectangle(4, 6);
            Shape oneTriangle = new Triangle(9, 2); 
            Shape anotherTriangle = new Triangle(3, 10);

            shapes.Add(oneSquare);
            shapes.Add(anotherSquare);
            shapes.Add(oneRectangle);
            shapes.Add(anotherRectangle);
            shapes.Add(oneTriangle);
            shapes.Add(anotherTriangle);

            foreach (var item in shapes)
            {
                var surface = item.CalculateSurface();
                Console.WriteLine("{0} (width {1}, height {2}) => surface: {3}",item.GetType().Name,item.Width, item.Height,surface);
            }
        }
    }
}
