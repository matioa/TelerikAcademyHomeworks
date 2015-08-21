//Problem 9. Delete odd lines
//    Write a program that deletes from given text file all odd lines.
//    The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../Input.txt");
        List<string> textLines = new List<string>();

        using (reader)
        {
            string line = reader.ReadLine();
            while (line!=null)
            {
                textLines.Add(line);
                line = reader.ReadLine();
            }
        }
        StreamWriter writer = new StreamWriter(@"../../Input.txt");
        using (writer)
        {
            for (int i = 0; i < textLines.Count; i++)
            {
                // The text lines start from 1, the list elements start from 0, so we will delete all even list elements
                if (i % 2 ==0)
                {
                    writer.WriteLine();
                }
                else
                {
                    writer.WriteLine(textLines[i]);
                }
            }
        }
        Console.WriteLine("Done");
    }
}

