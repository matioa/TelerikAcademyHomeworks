//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int theNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Before bit exchange");
        Console.WriteLine(theNumber);
        Console.WriteLine(Convert.ToString(theNumber,2).PadLeft(32,'0'));

        for (int positionExchangeA = 3; positionExchangeA <= 5; positionExchangeA++)
        {
            int positionExchangeB = positionExchangeA + 21;
            int maskA = 1 << positionExchangeA;
            int NumberAndMaskA = theNumber & maskA;
            int bitA = NumberAndMaskA >> positionExchangeA;

            int maskB = 1 << positionExchangeB;
            int NumberAndMaskB = theNumber & maskB;
            int bitB = NumberAndMaskB >> positionExchangeB;

            if (bitB == 1)
            {
                maskA = 1 << positionExchangeA;
                theNumber = theNumber | maskA;
            }
            else
            {
                maskA = ~(1 << positionExchangeA);
                theNumber = theNumber & maskA;
            }

            if (bitA == 1)
            {
                maskB = 1 << positionExchangeB;
                theNumber = theNumber | maskB;
            }
            else
            {
                maskB = ~(1 << positionExchangeB);
                theNumber = theNumber & maskB;
            }
        }
        Console.WriteLine();
        Console.WriteLine("After bit exchange");
        Console.WriteLine(Convert.ToString(theNumber, 2).PadLeft(32, '0'));
        Console.WriteLine(theNumber);
        Console.WriteLine();
    }
}

