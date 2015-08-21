using System;
using System.Collections.Generic;

namespace _02.IEnumerableExtensions
{
    class IEnumerableExtensionsMain
    {
        static void Main()
        {
            //Testing int
            var numbers = new List<int>();
            for (int i = 1; i < 7; i++)
            {
                numbers.Add(i);
            }

            var resultSumInt = numbers.MySum();
            var resultProductInt = numbers.MyProduct();
            var resultAverageInt = numbers.MyAverage();
            var resultMinInt = numbers.MyMin();
            var resultMaxInt = numbers.MyMax();

            foreach (var number in numbers)
            {
                Console.Write(number);
                Console.Write('|');
            }
            Console.WriteLine("\nSum (int): {0}",resultSumInt);
            Console.WriteLine("Product (int): {0}", resultProductInt);
            Console.WriteLine("Average (int): {0}", resultAverageInt);
            Console.WriteLine("Min (int): {0}", resultMinInt);
            Console.WriteLine("Max (int): {0}", resultMaxInt);


            Console.WriteLine(new string('=',30));

            //Testing double
            var numbersDouble = new List<double>();
            for (int i = 1; i < 7; i++)
            {
                numbersDouble.Add(i*1.2);
            }

            var resultSumDouble = numbersDouble.MySum();
            var resultProductDouble = numbersDouble.MyProduct();
            var resultAverageDouble = numbersDouble.MyAverage();
            var resultMinDouble = numbersDouble.MyMin();
            var resultMaxDouble = numbersDouble.MyMax();
            
            foreach (var number in numbersDouble)
            {
                Console.Write(number);
                Console.Write('|');
            }
            Console.WriteLine("\nSum (double): {0}", resultSumDouble);
            Console.WriteLine("Product (double): {0}", resultProductDouble);
            Console.WriteLine("Average (double): {0}", resultAverageDouble);
            Console.WriteLine("Min (double): {0}", resultMinDouble);
            Console.WriteLine("Max (double): {0}", resultMaxDouble);


            Console.WriteLine(new string('=', 30));

            //Test with string
            string[] textCollection =  {"DodoJuice", "Pulpi"};
            var maxText = textCollection.MyMax();
            Console.WriteLine(maxText);

            
        }
    }
}
