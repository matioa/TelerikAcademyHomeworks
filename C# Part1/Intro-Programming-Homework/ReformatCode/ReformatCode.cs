//Problem 10. Reformat C# Code

//Reformat the following C# code to make it readable according to the C# best practices for code formatting. 
//Change the casing of the identifiers in the code (e.g. use PascalCase for the class name): HorribleCode.cs

using System;

class hoRRiblEcoDe
{
    static void Main()
    {
        Console.WriteLine("Hi, I am horribly formatted program"); 
        Console.WriteLine("Numbers and squares:"); 
        for (int i = 2;i < 100;i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i+", ");
            }
            else 
            {
                Console.Write(-i+", ");
            }
        }
        Console.WriteLine("Abs of the number -7 is {0}", Math.Abs(-7)); 
        Console.WriteLine("Square of 9 is {0}", Math.Sqrt(9)); 
        Console.WriteLine("Square of 10 is {0}", Math.Sqrt(10)); 
        Console.WriteLine("PI is {0}", Math.PI);
        Console.ReadKey();
    }
}