﻿namespace Abstraction
{
    using System;

    class FiguresExample
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle.ToString());

            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle.ToString());
        }
    }
}
