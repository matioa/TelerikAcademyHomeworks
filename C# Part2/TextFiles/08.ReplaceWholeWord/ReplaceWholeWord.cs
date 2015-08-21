//Problem 8. Replace whole word
//    Modify the solution of the previous problem to replace only whole words (not strings).


using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../Input.txt");
        StreamWriter writer = new StreamWriter(@"../../Output.txt");
        string input = string.Empty;
        string textOut = "start";
        string textIn = "finish";
        //The metacharacter \b is an anchor like the caret and the dollar sign. It matches at a position that is called a "word boundary".
        string pattern = String.Format(@"\b{0}\b", textOut); 

        using (reader)
        {
            using (writer)
            {
                input = reader.ReadLine();
                while (input != null)
                {
                    string result = Regex.Replace(input, pattern, textIn);
                    writer.WriteLine(result);
                    input = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("File genearted");
    }
}

