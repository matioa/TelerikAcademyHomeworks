using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

static class RemoveWords
{
    static void Main()
    {
        StreamReader readWordsToRemove = new StreamReader(@"..//..//WordsToRemove.txt");
        List<string> listWordsToRemove = new List<string>();
        using (readWordsToRemove)
        {
            string line = readWordsToRemove.ReadLine();
            while (line != null)
            {
                listWordsToRemove.Add(line);
                line = readWordsToRemove.ReadLine();
            }
        }

        StreamReader readerText = new StreamReader(@"..//..//Input.txt");
        using (readerText)
        {
            string line = readerText.ReadLine();
            while (line != null)
            {
                StringBuilder fixedLine = new StringBuilder(line);
                foreach (var removeWord in listWordsToRemove)
                {
                    fixedLine = ReplaceWholeWord(fixedLine.ToString(), removeWord, "");
                }
                Console.WriteLine(fixedLine);
                line = readerText.ReadLine();
            }
        }
        Console.WriteLine("=============");
        Console.WriteLine("Words removed.");
    }

    static StringBuilder ReplaceWholeWord(this string s, String word, String bywhat)
    {
        char firstLetter = word.ToLower()[0];
        StringBuilder sb = new StringBuilder();
        bool previousWasLetterOrDigit = false;
        int i = 0;
        while (i < s.Length - word.Length + 1)
        {
            bool wordFound = false;
            char c = s.ToLower()[i];
            if (c == firstLetter)
                if (!previousWasLetterOrDigit)
                    if (s.Substring(i, word.Length).ToLower().Equals(word.ToLower()))
                    {
                        wordFound = true;
                        bool wholeWordFound = true;
                        if (s.Length > i + word.Length)
                        {
                            if (Char.IsLetterOrDigit(s[i + word.Length]))
                                wholeWordFound = false;
                        }

                        if (wholeWordFound)
                            sb.Append(bywhat);
                        else
                            sb.Append(word);

                        i += word.Length;
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

        return sb;
    }
}

