using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        string openTag = "<upcase>";
        string closeTag = "</upcase>";
        int startIndex = 0;
        int openTagPosition = 0;
        int closeTagPosition = 0;
        int upCaseLength = closeTagPosition - (openTagPosition + openTag.Length);
        StringBuilder newText = new StringBuilder();

        openTagPosition = text.IndexOf(openTag);
        if (openTagPosition < 0)
        {
            Console.WriteLine(text);
        }
        else
        {
            do
            {
                string lowerCaseText = text.Substring(startIndex, openTagPosition - startIndex);
                newText.Append(lowerCaseText);
                closeTagPosition = text.IndexOf(closeTag, startIndex)+closeTag.Length;
                string upperCaseText = text.Substring(openTagPosition + openTag.Length, closeTagPosition - closeTag.Length - (openTagPosition+openTag.Length)).ToUpper();
                newText.Append(upperCaseText);
                startIndex = closeTagPosition;
                openTagPosition = text.IndexOf(openTag, startIndex);
            } while (openTagPosition >= 0);
        }

        newText.Append(text.Substring(startIndex));
        Console.WriteLine(newText);

    }
}

