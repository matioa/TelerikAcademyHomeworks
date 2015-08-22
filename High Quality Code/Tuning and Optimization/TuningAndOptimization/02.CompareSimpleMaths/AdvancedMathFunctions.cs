using System;
using System.Diagnostics;

namespace _02.CompareSimpleMaths
{
    class AdvancedMathFunctions
    {
        public enum AdvancedOperations { SqrRoot, Logarithm, Sinus };
        private const int anotherValue = 1;
        private const int TestsCount = 10;
        private const int RepeatFunctionsCount = 1000000;

        public static void ComparePerformance(float value, AdvancedOperations function)
        {
            var result = value;
            Stopwatch stopwatch = new Stopwatch();

            for (var j = 0; j < TestsCount; j++)
            {
                var testNumber = value;
                stopwatch.Start();

                for (var i = 0; i < RepeatFunctionsCount; i++)
                {
                    switch (function)
                    {
                        case AdvancedOperations.SqrRoot: testNumber = (float)Math.Sqrt(value); break;
                        case AdvancedOperations.Logarithm: testNumber = (float)Math.Log(value); break;
                        case AdvancedOperations.Sinus: testNumber = (float)Math.Sin(value); break;
                    }
                }

                stopwatch.Stop();
            }
            Console.WriteLine(value.GetType().ToString() + " time in milliseconds: " + stopwatch.Elapsed.Milliseconds / TestsCount);
        }

        public static void ComparePerformance(double value, AdvancedOperations function)
        {
            var result = value;
            Stopwatch stopwatch = new Stopwatch();

            for (var j = 0; j < TestsCount; j++)
            {
                var testNumber = value;
                stopwatch.Start();

                for (var i = 0; i < RepeatFunctionsCount; i++)
                {
                    switch (function)
                    {
                        case AdvancedOperations.SqrRoot: testNumber = (double)Math.Sqrt(value); break;
                        case AdvancedOperations.Logarithm: testNumber = (double)Math.Log(value); break;
                        case AdvancedOperations.Sinus: testNumber = (double)Math.Sin(value); break;
                    }
                }

                stopwatch.Stop();
            }
            Console.WriteLine(value.GetType().ToString() + " time in milliseconds: " + stopwatch.Elapsed.Milliseconds / TestsCount);
        }

        public static void ComparePerformance(decimal value, AdvancedOperations function)
        {
            var result = value;
            Stopwatch stopwatch = new Stopwatch();

            for (var j = 0; j < TestsCount; j++)
            {
                var testNumber = value;
                stopwatch.Start();

                for (var i = 0; i < RepeatFunctionsCount; i++)
                {
                    switch (function)
                    {
                        case AdvancedOperations.SqrRoot: testNumber = (decimal)Math.Sqrt((double)value); break;
                        case AdvancedOperations.Logarithm: testNumber = (decimal)Math.Log((double)value); break;
                        case AdvancedOperations.Sinus: testNumber = (decimal)Math.Sin((double)value); break;
                    }
                }

                stopwatch.Stop();
            }
            Console.WriteLine(value.GetType().ToString() + " time in milliseconds: " + stopwatch.Elapsed.Milliseconds / TestsCount);
        }
    }
}
