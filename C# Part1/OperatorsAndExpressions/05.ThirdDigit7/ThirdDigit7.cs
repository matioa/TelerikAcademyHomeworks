//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Checks for given number if its third digit from right-to-left is 7.");
        Console.Write("Enter number:");

        string enteredNumber = Console.ReadLine();
        int startPosition = enteredNumber.Length -3;
        int thirdDigit = Convert.ToInt16(enteredNumber.Substring(startPosition, 1));
        bool isSeven = thirdDigit == 7;

        Console.WriteLine("{0}. The third digit is {1}", isSeven, thirdDigit);
        Console.WriteLine();
    }
}
