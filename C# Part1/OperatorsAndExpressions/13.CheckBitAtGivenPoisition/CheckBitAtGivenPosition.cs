//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number:");
        int theNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position p:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = theNumber & mask;
        int bit = nAndMask >> p;
        bool isBit1 = bit == 1;
        Console.WriteLine(Convert.ToString(theNumber, 2).PadLeft(8, '0'));
        Console.WriteLine("Bit@{0} is 1?   {1}", p, isBit1);
    }
}

