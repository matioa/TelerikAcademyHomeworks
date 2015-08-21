//Problem 14. Word dictionary
//    A dictionary is stored as a sequence of text lines containing words and their explanations.
//    Write a program that enters a word and translates it by using the dictionary.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        dict[".NET"] = "platform for applications from Microsoft";
        dict["CLR"] = "managed execution environment for .NET";
        dict["namespace"] = "hierarchical organization of classes";

        Console.WriteLine("Enter one of the following to find out its explanation: ");
        Console.WriteLine(".Net\nCLR\nnamespace\n");
        string input = Console.ReadLine();
        Console.WriteLine(dict[input]);

    }
}

