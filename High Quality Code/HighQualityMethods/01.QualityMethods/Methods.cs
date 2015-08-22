namespace Methods
{
    using System;

    class Methods
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            bool sidesArePositive = (a > 0) && (b > 0) && (c > 0);
            bool sidesCanFormTriangle = (a + b > c) && (a + c > b) && (b + c > a);

            if (!sidesArePositive)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            if (!sidesCanFormTriangle)
            {
                throw new ArgumentException("Sides do not form a triangle.");
            }

            double sum = (a + b + c) / 2;
            double area = Math.Sqrt(sum * (sum - a) * (sum - b) * (sum - c));

            bool maxValueExceeded = Double.IsPositiveInfinity(sum) || Double.IsPositiveInfinity(area);
            if (maxValueExceeded)
            {
                throw new ArgumentOutOfRangeException("Triangle area exceeds double Maximum value.");
            }

            return area;
        }

        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return number + "is not between 0 and 9";
            }
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        internal static void PrintNumberWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }


        internal static void PrintNumberAsPercentage(double number)
        {
            {
                Console.WriteLine("{0:p0}", number);
            }
        }


        internal static void PrintNumberAlignedRight(double number)
        {
            Console.WriteLine("{0,8}", number);
        }



        internal static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        internal static bool IsLineHorizontal(double x1, double x2)
        {
            return x1 == x2;
        }

        internal static bool IsLineVertical(double y1, double y2)
        {
            return y1 == y2;
        }
    }
}

