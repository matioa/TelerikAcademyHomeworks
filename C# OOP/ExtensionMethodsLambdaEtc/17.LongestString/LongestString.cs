using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.LongestString
{
    class LongestString
    {
        static void Main()
        {
            List<string> textArray = new List<string>();
            textArray.Add("Write a program to return the string with maximum length from an array of strings.");
            textArray.Add("Rewrite the previous using extension methods.");
            textArray.Add("Use extension methods");

            var longestString = textArray
                                .OrderByDescending(x => x.Length)
                                .First();

            Console.WriteLine(longestString);

        }
    }
}
