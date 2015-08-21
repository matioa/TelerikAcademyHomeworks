//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number in the range (0-999)");
            int userNumber = int.Parse(Console.ReadLine());
            int remaining;
            if (userNumber == 0)
            {
	            Console.WriteLine("Zero");
            } else 
            {
	            if (userNumber / 100 > 0)
	            {
		            switch (userNumber / 100)
		            {
			            case 1: Console.Write("One"); break;
			            case 2: Console.Write("Two"); break;
			            case 3: Console.Write("Three"); break;
			            case 4: Console.Write("Four"); break;
			            case 5: Console.Write("Five"); break;
			            case 6: Console.Write("Six"); break;
			            case 7: Console.Write("Seven"); break;
			            case 8: Console.Write("Eight"); break;
			            case 9: Console.Write("Nine"); break;
		            }
		            Console.Write(" hundred");
	            }
                remaining = userNumber - ((userNumber / 100) * 100);
                if ((remaining != 0) && (userNumber / 100 > 0))
	            {
		            Console.Write(" and ");
	            }
                if (remaining >= 10 && remaining <= 19)
                {
                    switch (remaining)
                    {
                        case 10: Console.Write("ten"); break;
                        case 11: Console.Write("eleven"); break;
                        case 12: Console.Write("twelve"); break;
                        case 13: Console.Write("thirteen"); break;
                        case 14: Console.Write("fourteen"); break;
                        case 15: Console.Write("fifteen"); break;
                        case 16: Console.Write("sixteen"); break;
                        case 17: Console.Write("seventeen"); break;
                        case 18: Console.Write("eighteen"); break;
                        case 19: Console.Write("nineteen"); break;
                    }
                }
                else
                {
                    if ((userNumber / 10) % 10 >= 2)
                    {
                        switch ((userNumber / 10) % 10)
                        {
                            case 2: Console.Write("twenty "); break;
                            case 3: Console.Write("thirty "); break;
                            case 4: Console.Write("forty "); break;
                            case 5: Console.Write("fifty "); break;
                            case 6: Console.Write("sixty "); break;
                            case 7: Console.Write("seventy "); break;
                            case 8: Console.Write("eighty "); break;
                            case 9: Console.Write("ninety "); break;
                        }
                    }
                    if (userNumber % 10 >= 1)
                    {
                        switch (userNumber % 10)
                        {
                            case 1: Console.Write("one"); break;
                            case 2: Console.Write("two"); break;
                            case 3: Console.Write("three"); break;
                            case 4: Console.Write("four"); break;
                            case 5: Console.Write("five"); break;
                            case 6: Console.Write("six"); break;
                            case 7: Console.Write("seven"); break;
                            case 8: Console.Write("eight"); break;
                            case 9: Console.Write("nine"); break;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
