//Problem 1. Decimal to binary
//• Write a program to convert decimal numbers to their binary representation.


using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int input = int.Parse(Console.ReadLine());
        string toBinary = DecToBin(input);
        Console.WriteLine("Deciaml number {0} in binary numeral system = {1}",input, toBinary.PadLeft(8,'0'));
    }

    static string DecToBin(int number)
    {
        int decNumber = number;
        List<int> binary = new List<int>();

        while (decNumber >0)
        {
            if (decNumber % 2 ==0 )
	        {
		        binary.Add(0);
	        }else
	        {
                binary.Add(1);
	        }
            decNumber /=2;
        }

        binary.Reverse();
        string binaryNumber = string.Join("",binary);
        return binaryNumber;
    }
}

