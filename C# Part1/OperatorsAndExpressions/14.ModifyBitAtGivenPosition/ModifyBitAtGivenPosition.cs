//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int theNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Choose bit value (0 or 1): ");
        int v = int.Parse(Console.ReadLine());
        bool vIsCorrect = (v == 0 || v == 1);

        if (!vIsCorrect)
        {
            do
            {
                Console.Write("Enter only 1 or 0!!!! \nChoose bit value (0 or 1): ");
                v = int.Parse(Console.ReadLine());
                vIsCorrect = (v == 0 || v == 1);
            } while (!vIsCorrect);
        }

        if (v == 1)
        {
            int mask = 1 << p;
            int result = theNumber | mask;
            Console.WriteLine("Number in binary "+ Convert.ToString(theNumber, 2).PadLeft(8, '0'));
            Console.WriteLine("Result in binary " + Convert.ToString(result, 2).PadLeft(8, '0'));
        }
        else
        {
            int mask = ~(1 << p);
            int result = theNumber & mask;
            Console.WriteLine("Number in binary " + Convert.ToString(theNumber, 2).PadLeft(8, '0'));
            Console.WriteLine("Result in binary " + Convert.ToString(result, 2).PadLeft(8, '0'));
        }

    }
}

