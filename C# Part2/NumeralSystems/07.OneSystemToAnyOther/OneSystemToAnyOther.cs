//Problem 7. One system to any other
//• Write a program to convert from any numeral system of given base  s  to any other numeral system of base  d  (2 ≤  s ,  d  ≤ 16).


using System;
using System.Collections.Generic;
using System.Linq;

namespace OneSystemToAny
{


    class OneSystemToAnyOther
    {
        static void Main()
        {
            Console.Write("Enter numberic system s (interval 2-16): ");
            int numSystem1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            Console.Write("Enter numberic system to convert to (interval 2-16): ");
            int numSystem2 = int.Parse(Console.ReadLine());

            double dec = NumSystem1ToDecimal(number, numSystem1);
            string newNum = DecimalToNumSystem2(dec, numSystem2);
            Console.WriteLine("\nNumber in {0} num system: {1}", numSystem1, number);
            Console.WriteLine("Deciaml number: {0}", dec);
            Console.WriteLine("Number in {0} num system: {1}\n", numSystem2, newNum);


        }

        static double NumSystem1ToDecimal(string number, int numSystem)
        {
            double result = 0;
            string numSystemElements = "0123456789ABCDEF";

            var revNumber = number.Reverse();
            int counter = 0;
            foreach (var item in revNumber)
            {
                int position = numSystemElements.IndexOf(item);
                result += position * (Math.Pow(numSystem, counter));
                counter++;
            }
            return result;
        }

        static string DecimalToNumSystem2(double decNumber, int numSystem2)
        {
            string numSystemElements = "0123456789ABCDEF";
            List<char> number = new List<char>();
            while (decNumber > 0)
            {
                int index = (int)(decNumber % numSystem2);
                number.Add(numSystemElements[index]);
                decNumber = (int)(decNumber / numSystem2);
            }
            number.Reverse();
            string result = new string(number.ToArray());
            return result;
        }
    }

}