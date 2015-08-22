namespace _02.CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public static class SimpleMathFunctions
    {
        public enum Operations { Add, Division, Substraction, Multiply, Increment };
        private const int anotherValue = 1;
        private const int TestsCount = 10;
        private const int RepeatFunctionsCount = 1000000;


        public static void ComparePerformance(int value, Operations funcion)
        {
            var result = value;
            Stopwatch stopwatch = new Stopwatch();

            for (var j = 0; j < TestsCount; j++)
            {
                var testNumber = value;
                stopwatch.Start();

                for (var i = 0; i < RepeatFunctionsCount; i++)
                {
                    switch (funcion)
                    {
                        case Operations.Add: testNumber += anotherValue; break;
                        case Operations.Division: testNumber %= anotherValue; break;
                        case Operations.Substraction: testNumber -= anotherValue; break;
                        case Operations.Multiply: testNumber *= anotherValue; break;
                        case Operations.Increment: testNumber++; break;
                    }
                }

                stopwatch.Stop();
            }
            Console.WriteLine(value.GetType().ToString() + " time in milliseconds: " + stopwatch.Elapsed.Milliseconds / TestsCount);
        }

        public static void ComparePerformance(long value, Operations funcion)
        {
            var result = value;
            Stopwatch stopwatch = new Stopwatch();

            for (var j = 0; j < TestsCount; j++)
            {
                var testNumber = value;
                stopwatch.Start();

                for (var i = 0; i < RepeatFunctionsCount; i++)
                {
                    switch (funcion)
                    {
                        case Operations.Add: testNumber += anotherValue; break;
                        case Operations.Division: testNumber %= anotherValue; break;
                        case Operations.Substraction: testNumber -= anotherValue; break;
                        case Operations.Multiply: testNumber *= anotherValue; break;
                        case Operations.Increment: testNumber++; break;
                    }
                }

                stopwatch.Stop();
            }
            Console.WriteLine(value.GetType().ToString() + " time in milliseconds: " + stopwatch.Elapsed.Milliseconds / TestsCount);
        }

        public static void ComparePerformance(float value, Operations funcion)
        {
            var result = value;
            Stopwatch stopwatch = new Stopwatch();

            for (var j = 0; j < TestsCount; j++)
            {
                var testNumber = value;
                stopwatch.Start();

                for (var i = 0; i < RepeatFunctionsCount; i++)
                {
                    switch (funcion)
                    {
                        case Operations.Add: testNumber += anotherValue; break;
                        case Operations.Division: testNumber %= anotherValue; break;
                        case Operations.Substraction: testNumber -= anotherValue; break;
                        case Operations.Multiply: testNumber *= anotherValue; break;
                        case Operations.Increment: testNumber++; break;
                    }
                }

                stopwatch.Stop();
            }
            Console.WriteLine(value.GetType().ToString() + " time in milliseconds: " + stopwatch.Elapsed.Milliseconds / TestsCount);
        }

        public static void ComparePerformance(double value, Operations funcion)
        {
            var result = value;
            Stopwatch stopwatch = new Stopwatch();

            for (var j = 0; j < TestsCount; j++)
            {
                var testNumber = value;
                stopwatch.Start();

                for (var i = 0; i < RepeatFunctionsCount; i++)
                {
                    switch (funcion)
                    {
                        case Operations.Add: testNumber += anotherValue; break;
                        case Operations.Division: testNumber %= anotherValue; break;
                        case Operations.Substraction: testNumber -= anotherValue; break;
                        case Operations.Multiply: testNumber *= anotherValue; break;
                        case Operations.Increment: testNumber++; break;
                    }
                }

                stopwatch.Stop();
            }
            Console.WriteLine(value.GetType().ToString() + " time in milliseconds: " + stopwatch.Elapsed.Milliseconds / TestsCount);
        }

        public static void ComparePerformance(decimal value, Operations funcion)
        {
            var result = value;
            Stopwatch stopwatch = new Stopwatch();

            for (var j = 0; j < TestsCount; j++)
            {
                var testNumber = value;
                stopwatch.Start();

                for (var i = 0; i < RepeatFunctionsCount; i++)
                {
                    switch (funcion)
                    {
                        case Operations.Add: testNumber += anotherValue; break;
                        case Operations.Division: testNumber %= anotherValue; break;
                        case Operations.Substraction: testNumber -= anotherValue; break;
                        case Operations.Multiply: testNumber *= anotherValue; break;
                        case Operations.Increment: testNumber++; break;
                    }
                }

                stopwatch.Stop();
            }
            Console.WriteLine(value.GetType().ToString() + " time in milliseconds: " + stopwatch.Elapsed.Milliseconds / TestsCount);
        }
    }
}
