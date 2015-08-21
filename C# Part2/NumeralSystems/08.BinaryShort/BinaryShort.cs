//Problem 8. Binary short
//• Write a program that shows the binary representation of given 16-bit signed integer number (the C# type  short ).


using System;
using System.Collections.Generic;


class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        short input = short.Parse(Console.ReadLine());
        string toBinary = ShortToBin(input);
        Console.WriteLine("Deciaml number {0} in binary numeral system = {1}", input, toBinary);

    }

    static string ShortToBin(short number)
    {
        short numberPositive = 0;
        if (number<0)
	    {
            numberPositive = (short)(Math.Pow(2,15) + number);
	    }else
	    {
            numberPositive = number;
	    }

        List<int> binary = new List<int>();

        while (numberPositive > 0)
        {
            if (numberPositive % 2 == 0)
            {
                binary.Add(0);
            }
            else
            {
                binary.Add(1);
            }
            numberPositive /= 2;
        }

        for (int i = binary.Count+1; i < 16; i++)
        {
            binary.Add(0);
        }
        if (number<0)
        {
            binary.Add(1);
        }
        else
        {
            binary.Add(0);
        }

        binary.Reverse();
        string binaryNumber = string.Join("", binary);
        return binaryNumber;
    }
}
