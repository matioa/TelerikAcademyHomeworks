using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        //Regex patter taken from http://net.tutsplus.com/tutorials/other/8-regular-expressions-you-should-know/. 
        //Modified to accept at least 2 symbols after "@".
        string regExEmailPatter = @"([a-z0-9_\.-]+)@([\da-z\.-]{2,})\.([a-z\.]{2,6})";
        string sampleText = "You can email us at sometexxt@abv.bg. Samle non-emails email@google, some more @yahoo.com.";

        MatchCollection matches = Regex.Matches(sampleText, regExEmailPatter);

        Console.WriteLine("Text is: ");
        Console.WriteLine(sampleText);
        Console.WriteLine("\nE-mails:\n");
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
            Console.WriteLine();
        }
    }
}


