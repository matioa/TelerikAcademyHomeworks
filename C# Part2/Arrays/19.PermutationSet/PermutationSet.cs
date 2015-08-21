using System;
using System.Collections.Generic;

class PermutationSet
{
    static void Main()
    {
        List<string> numbers = new List<string>();

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                numbers.Add(numbers[j]+Convert.ToString(i));
            }
        }
    }
}

