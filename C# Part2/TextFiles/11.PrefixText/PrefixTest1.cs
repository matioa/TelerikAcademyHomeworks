//Problem 11. Prefix "test"
//    Write a program that deletes from a text file all words that start with the prefix test.
//    Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text;

static class PrefixTest1
{
    static void Main()
    {
        string prefixOut = "test";

        using (StreamReader reader = new StreamReader("..//..//Input.txt"))
        {
            using (StreamWriter writer = new StreamWriter("..//..//Output.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string fixedLine = ReplacePrefix(line, prefixOut, "");
                    writer.WriteLine(fixedLine);
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Prefixes removed.");
    }


    static string ReplacePrefix(this String s, String word, String bywhat)
    {
        char firstLetter = word[0];
        StringBuilder sb = new StringBuilder();
        bool previousWasLetterOrDigit = false;
        int i = 0;
        while (i < s.Length - word.Length + 1)
        {
            bool wordFound = false;
            char c = s[i];
            if (c == firstLetter)
                if (!previousWasLetterOrDigit)
                    if (s.Substring(i, word.Length).Equals(word))
                    {
                        wordFound = true;

                        while (char.IsLetterOrDigit(s[i]) || s[i] == '_')
                        {
                            i++;
                            if (i>=s.Length)
                            {
                                break;
                            }
                        }
                        //THE FOLLOWING COMMENTED CODE IS USED TO REPLACE WHOLE WORD, NOT ONLY PREFIX
                        //bool wholeWordFound = true;
                        //if (s.Length > i + word.Length)
                        //{
                        //    if (Char.IsLetterOrDigit(s[i + word.Length]))
                        //        wholeWordFound = false;
                        //}

                        //if (wholeWordFound)
                        sb.Append(bywhat);
                        //else
                        //    sb.Append(word);

                        //i += word.Length;
                    }

            if (!wordFound)
            {
                previousWasLetterOrDigit = Char.IsLetterOrDigit(c);
                sb.Append(c);
                i++;
            }
        }

        if (s.Length - i > 0)
            sb.Append(s.Substring(i));

        return sb.ToString();
    }
}

