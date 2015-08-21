//Problem 7. Replace sub-string
//    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//    Ensure it will work with large files (e.g. 100 MB).


using System;
using System.IO;
using System.Text;

class ReplaceSubstring
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../Input.txt");
        StreamWriter writer = new StreamWriter(@"../../Output.txt");
        StringBuilder textLine = new StringBuilder();
        string input = string.Empty;
        string textOut = "start";
        string textIn = "finish";

        using (reader)
        {
            using (writer)
            {
                input = reader.ReadLine();
                while (input!=null)
                {
                    textLine.Append(input); 
                    textLine.Replace(textOut, textIn);
                    writer.WriteLine(textLine);
                    textLine.Clear();
                    input = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("File genearted");
    }
}

