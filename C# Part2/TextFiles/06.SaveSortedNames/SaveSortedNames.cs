//Problem 6. Save sorted names
//    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SaveSortedNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../Input.txt");
        List<string> names = new List<string>();

        using (reader)
        {
            string nameFromFile = reader.ReadLine();
            while (nameFromFile != null)
            {
                names.Add(nameFromFile);
                nameFromFile = reader.ReadLine();
            }
        }
        names.Sort();

        StreamWriter writer = new StreamWriter(@"../../Output.txt");
        using (writer)
        {
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine(names[i]);
            }
        }
        Console.WriteLine("File generated.");
    }
}

