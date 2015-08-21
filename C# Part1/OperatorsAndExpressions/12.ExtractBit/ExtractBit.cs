//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBit
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
        Console.WriteLine(Convert.ToString(theNumber, 2).PadLeft(8, '0'));
        Console.WriteLine("Bit@{0} is: {1}",p,bit);
    }
}
