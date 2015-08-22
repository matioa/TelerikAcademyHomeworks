using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class EnigmaCat
{
    private static void Main()
    {
        string[] codedMessage = Console.ReadLine().Split(' ');

        Validate(codedMessage);

        string decodedMessage = Decode(codedMessage);

        Console.WriteLine(decodedMessage);
    }


    private static void Validate(string[] input)
    {
        if (input == null || input.Length == 0)
        {
            throw new ArgumentNullException("Input cannot be null or empty string.");
        }
    }

    private static string Decode(string[] codedMessage)
    {
        List<string> decodedMessage = new List<string>();

        foreach (var codedWord in codedMessage)
        {
            BigInteger codedWordAsDecimalNumber = ConvertToDecimal(codedWord);
            string decodedWord = ConvertFromDecimal(codedWordAsDecimalNumber);
            decodedMessage.Add(decodedWord);
        }

        return string.Join(" ", decodedMessage);
    }

    private static string ConvertFromDecimal(BigInteger decNumber)
    {
        StringBuilder decodedMessage = new StringBuilder();

        while (decNumber > 0)
        {
            char decodedLetter = (char)((int)(decNumber % 26) + 'a');
            decodedMessage.Insert(0, decodedLetter);
            decNumber = decNumber / 26;
        }

        return decodedMessage.ToString(); ;
    }

    private static BigInteger ConvertToDecimal(string word)
    {
        BigInteger sum = 0;

        foreach (var ch in word)
        {
            sum *= 17;
            sum += ch - 'a';
        }

        return sum;
    }
}
