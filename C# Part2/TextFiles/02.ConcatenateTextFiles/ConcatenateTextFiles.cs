//Problem 2. Concatenate text files
//    Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        string fileContents1 = string.Empty;
        string fileContents2 = string.Empty;
        StreamReader reader1 = new StreamReader(@"../../Input1.txt");
        using (reader1)
        {
            fileContents1 = reader1.ReadToEnd();
        }

        StreamReader reader2 = new StreamReader(@"../../Input2.txt");
        using (reader2)
        {
            fileContents2 = reader2.ReadToEnd();
        }


        StreamWriter writer = new StreamWriter(@"..//../Output.txt");
        using (writer)
        {
            writer.WriteLine(fileContents1);
            writer.WriteLine(fileContents2);

        }

        Console.WriteLine("Output file generated");
    }
}

