//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int theNumber = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int nAndMask = theNumber & mask;
            int bit = nAndMask >> p;
            Console.WriteLine(Convert.ToString(theNumber, 2).PadLeft(8, '0'));
            Console.WriteLine("Bit@{0} is: {1}",p,bit);
        }
    }
