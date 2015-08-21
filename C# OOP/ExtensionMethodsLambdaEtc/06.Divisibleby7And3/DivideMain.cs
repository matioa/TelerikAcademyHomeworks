using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Divisibleby7And3
{
    class DivideMain
    {
        static void Main()
        {
            Random randomGenerator = new Random();

            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = randomGenerator.Next(1, 100);
            }

            //Using Linq & Lambda
            var filteredNumbers = numbers.Where(x => x % 7 == 0 || x % 3 == 0).ToArray();
            Console.WriteLine(string.Join(", ",filteredNumbers));

            //Using Linq
            var filteredNumbers2 =
                from number in numbers
                where number % 7 == 0 || number % 3 == 0
                select number;

            Console.WriteLine(string.Join(", ", filteredNumbers2));
        }
    }
}
