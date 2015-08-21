//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

using System;

class PlayingCards
{
    static void Main()
    {
        Console.WriteLine("Enter Card Face sign: ");
        string userInput = Console.ReadLine();
        int number;
        bool isNumber = int.TryParse(userInput, out number);
        if (!isNumber)
        {
            if (userInput == "J" ||
                userInput == "Q" ||
                userInput == "K" ||
                userInput == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
        {
            if (2 <= number && number<= 10)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

