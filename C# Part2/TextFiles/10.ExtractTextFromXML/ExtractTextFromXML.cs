//Problem 10. Extract text from XML
//    Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    static void Main(string[] args)
    {

        using (StreamReader reader = new StreamReader("..//..//Input.xml"))
        {
            string line = reader.ReadLine();
            string extract = string.Empty;
            while (line != null)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    if (line[i - 1] == '>')
                    {
                        while (line[i] != '<')
                        {
                            extract += line[i];
                            i++;
                        }
                        if (extract != "")
                        {
                            Console.WriteLine(extract.TrimStart(' '));
                            extract = "";
                        }
                    }
                }
                line = reader.ReadLine();
            }
        }
    }
}
