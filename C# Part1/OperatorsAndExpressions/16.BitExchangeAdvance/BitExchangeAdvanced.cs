//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter number:");
        long number = long.Parse(Console.ReadLine());

        Console.Write("Enter bit number p:");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter bit number q:");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter sequence lenght k:");
        int k = int.Parse(Console.ReadLine());

        int MinP = p;
        int MaxP = p + k -1;

        int MinQ = q;
        int MaxQ = q+k-1;

        bool inRange = (0 <= MinP && MinP <= 31) && (0<=MaxP && MaxP<=31) && (0<=MinQ && MinQ<=31) && (0<=MaxQ && MaxQ<=31);
        bool isOverlapping = ((MinQ<=MinP && MinP<=MaxQ) || (MinQ<=MaxP && MaxP<=MaxQ));

        if (!inRange)
        {
	        Console.WriteLine("Bit range (p or q) is out of range.");
        } else if (isOverlapping)
        {
	        Console.WriteLine("Bit ranges (p and q) are overlapping.");
        } else
        {
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));
        Console.WriteLine(number);

	        for (int i=0; i<k ;i++)
	        {
		        long bitP = (number & (1<<p) ) >> p;
		        long bitQ = (number & (1<<q) ) >> q;

		        if (bitQ ==1)
		        {
			        number = number | (1<<p);
		        } else
		        {
			        number = number & ~(1<<p);
		        }
		        if (bitP ==1)
		        {
			        number = number | (1<<q);
		        } else
		        {
			        number = number & ~(1<<q);
		        }
	        p++;
	        q++;
	        }

        Console.WriteLine();
        Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));
        Console.WriteLine(number);
        Console.WriteLine();
        }
    }
}