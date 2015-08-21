//Problem 10. Unicode characters
//    Write a program that converts a string to a sequence of C# Unicode character literals.
//    Use format strings.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        StringBuilder intputInUnicode = new StringBuilder();
        foreach (var letter in input)
        {
            intputInUnicode.Append(String.Format("\\u{0:X4}", (int)letter));
        }
        Console.WriteLine(intputInUnicode);
    }
}

