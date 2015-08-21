//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

    class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Enter 1 for int ; 2 for double ; 3 for string");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
	            case 1 : Console.WriteLine("Please enter int: ");
			            int userInputInt = int.Parse(Console.ReadLine());
			            Console.WriteLine(userInputInt + 1);
			            break;
	            case 2 : Console.WriteLine("Please enter double: ");
                        double userInputDouble = double.Parse(Console.ReadLine());
			            Console.WriteLine(userInputDouble + 1);
			            break;
	            case 3 : Console.WriteLine("Please enter string: ");
			            string userInputString = Console.ReadLine();
			            Console.WriteLine(userInputString+"*");
			            break;
	            default : Console.WriteLine("invalid input");break;
            }
        }
    }

