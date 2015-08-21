//Problem 1. Odd lines
//    Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../Input.txt");
        using (reader)
        {
            int lineNumber = 0;
            string fileContents = reader.ReadLine();

            while (fileContents != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine(fileContents);
                }
                fileContents = reader.ReadLine();
            }
        }
    }
}
