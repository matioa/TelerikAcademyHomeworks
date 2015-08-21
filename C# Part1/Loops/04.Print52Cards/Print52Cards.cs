//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class Print52Cards
{
    static void Main()
    {
        for (int i = 2; i < 15; i++)
        {
            for (int j = 3; j < 7; j++)
            {
                switch (i)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10: Console.Write("{0,2}{1} ", i, (char)j); break;
                    case 11: Console.Write(" J{0} ", (char)j); break;
                    case 12: Console.Write(" Q{0} ", (char)j); break;
                    case 13: Console.Write(" K{0} ", (char)j); break;
                    case 14: Console.Write(" A{0} ", (char)j); break;
                }
            }
            Console.WriteLine();
        }
    }
}
