// Task 2. Compare simple Maths
// and
// Task 3. Compare advanced Maths

namespace _02.CompareSimpleMaths
{
    using System;

    class CompareTests
    {
        public const int testValueInt = 100;
        private const long testValueLong = 10;
        private const float testValueFloat = 100.0F;
        private const double testValueDouble = 100.0;
        private const decimal testValueDeciaml = 100.0M;

        static void Main()
        {
            // TASK 2. Compare simple Maths
            Console.WriteLine("SIMPLE Math functions");

            Console.WriteLine("Add function");
            SimpleMathFunctions.ComparePerformance(testValueInt, SimpleMathFunctions.Operations.Add);
            SimpleMathFunctions.ComparePerformance(testValueLong, SimpleMathFunctions.Operations.Add);
            SimpleMathFunctions.ComparePerformance(testValueFloat, SimpleMathFunctions.Operations.Add);
            SimpleMathFunctions.ComparePerformance(testValueDouble, SimpleMathFunctions.Operations.Add);
            SimpleMathFunctions.ComparePerformance(testValueDeciaml, SimpleMathFunctions.Operations.Add);

            Console.WriteLine("\nSubstract function");
            SimpleMathFunctions.ComparePerformance(testValueInt, SimpleMathFunctions.Operations.Substraction);
            SimpleMathFunctions.ComparePerformance(testValueLong, SimpleMathFunctions.Operations.Substraction);
            SimpleMathFunctions.ComparePerformance(testValueFloat, SimpleMathFunctions.Operations.Substraction);
            SimpleMathFunctions.ComparePerformance(testValueDouble, SimpleMathFunctions.Operations.Substraction);
            SimpleMathFunctions.ComparePerformance(testValueDeciaml, SimpleMathFunctions.Operations.Substraction);

            Console.WriteLine("\nDivision function");
            SimpleMathFunctions.ComparePerformance(testValueInt, SimpleMathFunctions.Operations.Division);
            SimpleMathFunctions.ComparePerformance(testValueLong, SimpleMathFunctions.Operations.Division);
            SimpleMathFunctions.ComparePerformance(testValueFloat, SimpleMathFunctions.Operations.Division);
            SimpleMathFunctions.ComparePerformance(testValueDouble, SimpleMathFunctions.Operations.Division);
            SimpleMathFunctions.ComparePerformance(testValueDeciaml, SimpleMathFunctions.Operations.Division);

            Console.WriteLine("\nMultiply function");
            SimpleMathFunctions.ComparePerformance(testValueInt, SimpleMathFunctions.Operations.Multiply);
            SimpleMathFunctions.ComparePerformance(testValueLong, SimpleMathFunctions.Operations.Multiply);
            SimpleMathFunctions.ComparePerformance(testValueFloat, SimpleMathFunctions.Operations.Multiply);
            SimpleMathFunctions.ComparePerformance(testValueDouble, SimpleMathFunctions.Operations.Multiply);
            SimpleMathFunctions.ComparePerformance(testValueDeciaml, SimpleMathFunctions.Operations.Multiply);

            Console.WriteLine("\nIncrement function");
            SimpleMathFunctions.ComparePerformance(testValueInt, SimpleMathFunctions.Operations.Increment);
            SimpleMathFunctions.ComparePerformance(testValueLong, SimpleMathFunctions.Operations.Increment);
            SimpleMathFunctions.ComparePerformance(testValueFloat, SimpleMathFunctions.Operations.Increment);
            SimpleMathFunctions.ComparePerformance(testValueDouble, SimpleMathFunctions.Operations.Increment);
            SimpleMathFunctions.ComparePerformance(testValueDeciaml, SimpleMathFunctions.Operations.Increment);

            // TASK 3. Compare advanced Maths
            Console.WriteLine("\n\nADVANCED Math functions");

            Console.WriteLine("\nSquare root function");
            AdvancedMathFunctions.ComparePerformance(testValueFloat, AdvancedMathFunctions.AdvancedOperations.SqrRoot);
            AdvancedMathFunctions.ComparePerformance(testValueDouble, AdvancedMathFunctions.AdvancedOperations.SqrRoot);
            AdvancedMathFunctions.ComparePerformance(testValueDeciaml, AdvancedMathFunctions.AdvancedOperations.SqrRoot);

            Console.WriteLine("\nNatural Logarithm function");
            AdvancedMathFunctions.ComparePerformance(testValueFloat, AdvancedMathFunctions.AdvancedOperations.Logarithm);
            AdvancedMathFunctions.ComparePerformance(testValueDouble, AdvancedMathFunctions.AdvancedOperations.Logarithm);
            AdvancedMathFunctions.ComparePerformance(testValueDeciaml, AdvancedMathFunctions.AdvancedOperations.Logarithm);

            Console.WriteLine("\nSinus function");
            AdvancedMathFunctions.ComparePerformance(testValueFloat, AdvancedMathFunctions.AdvancedOperations.Sinus);
            AdvancedMathFunctions.ComparePerformance(testValueDouble, AdvancedMathFunctions.AdvancedOperations.Sinus);
            AdvancedMathFunctions.ComparePerformance(testValueDeciaml, AdvancedMathFunctions.AdvancedOperations.Sinus);
        }
    }
}
