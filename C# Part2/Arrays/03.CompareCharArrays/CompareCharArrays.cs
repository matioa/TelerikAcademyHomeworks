//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        //Check which input has more characters. Then checks if the characters from the shorter input are available in the longer input.

        Console.Write("Write a sequance of chars (Input 1): ");
        string userInput1 = Console.ReadLine();
        Console.Write("Write a another sequance of chars (Input 2): ");
        string userInput2 = Console.ReadLine();
        char[] charArray1 = userInput1.ToCharArray();
        char[] charArray2= userInput2.ToCharArray();
        Console.WriteLine();

        int inputLength1 = userInput1.Length;
        int inputLength2 = userInput2.Length;
        int counter = 0;

        //Option 1: the two arrays lengths are equal
        if (inputLength1 == inputLength2)
        {
            for (int primary = 0; primary < inputLength1; primary++)
            {
                for (int j = 0; j < inputLength2; j++)
                {
                    if (charArray2[j] == charArray1[primary])
                    {
                        counter++;
                    }
                }
            }

            if (counter == inputLength1)
            {
                Console.WriteLine("Input 1 and Input 2 contain the same letters.");
            }                            
            else                         
            {                            
                Console.WriteLine("Input 1 and Input 2 have different letters.");
            }
        }
        //Option 2: array 1 is bigger than array 2
        else if (inputLength1 > inputLength2)
        {
            for (int primary = 0; primary < inputLength2; primary++)
            {
                for (int j = 0; j < inputLength1; j++)
                {
                    if (charArray1[j] == charArray2[primary])
                    {
                        counter++;
                    }
                }
            }
            if (counter ==inputLength2)
            {
                Console.WriteLine("Input 1 contains more characters than Input 2.");
                Console.WriteLine("Input 1 contains all characters from Input 2.");
            }
            else
            {
                Console.WriteLine("Input 1 contains more characters than Input 2.");
                Console.WriteLine("Input 1 does not contain all characters from Input 2.");
            }
        }
        //Option 3: Array 2 is bigger than array 1
        else
        {
            for (int primary = 0; primary < inputLength2; primary++)
            {
                for (int j = 0; j < inputLength1; j++)
                {
                    if (charArray1[j] == charArray2[primary])
                    {
                        counter++;
                    }
                }
            }
            if (counter == inputLength1)
            {
                Console.WriteLine("Input 2 contains more characters than Input 1.");
                Console.WriteLine("Input 2 contains all characters from Input 1.");
            }
            else
            {
                Console.WriteLine("Input 2 contains more characters than Input 1.");
                Console.WriteLine("Input 2 does not contain all characters from Input 1.");
            }

        }
        Console.WriteLine();
    }
}

