//Problem 3. Line numbers

//    Write a program that reads a text file and inserts line numbers in front of each of its lines.
//    The result should be written to another text file.


using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../Input.txt");
        StreamWriter writer = new StreamWriter(@"../../Output.txt");

        using (reader)
        {
            int counter = 0;
            string fileContent = reader.ReadLine();
            using (writer)
            {
                while (fileContent != null)
                {
                    counter++;
                    writer.WriteLine("{0} {1}", counter, fileContent);
                    fileContent = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("File generated.");
    }
}

