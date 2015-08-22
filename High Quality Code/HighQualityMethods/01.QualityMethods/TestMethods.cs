namespace Methods
{
    using System;

    class TestMethods
    {
        private static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintNumberWithPrecision(1.3);
            Methods.PrintNumberAlignedRight(0.75);
            Methods.PrintNumberAlignedRight(2.30);

            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5));

            bool isHorizontal = Methods.IsLineHorizontal(3, 3);
            bool isVertical = Methods.IsLineVertical(-1, 2.5);

            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992,03,17), "From Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11,03), "From Vidin, gamer, high results");
            
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
