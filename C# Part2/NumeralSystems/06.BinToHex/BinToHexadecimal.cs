//Problem 6. Binary to hexadecimal
//• Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;

class BinToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string input = Console.ReadLine();
        Console.WriteLine(BinToHex(input));

    }

    static string BinToHex(string binary)
    {
        binary = binary.PadLeft(64, '0');
        string hexNumber = "";
        for (int i = 0; i < binary.Length; i+=4)
        {
            string part = binary.Substring(i, 4);
            string hexPart = "";
            switch (part)
            {
                case "0000": hexPart = "0"; break;
                case "0001": hexPart = "1"; break;
                case "0010": hexPart = "2"; break;
                case "0011": hexPart = "3"; break;
                case "0100": hexPart = "4"; break;
                case "0101": hexPart = "5"; break;
                case "0110": hexPart = "6"; break;
                case "0111": hexPart = "7"; break;
                case "1000": hexPart = "8"; break;
                case "1001": hexPart = "9"; break;
                case "1010": hexPart = "A"; break;
                case "1011": hexPart = "B"; break;
                case "1100": hexPart = "C"; break;
                case "1101": hexPart = "D"; break;
                case "1110": hexPart = "E"; break;
                case "1111": hexPart = "F"; break;
            }
            hexNumber += hexPart;
        }
        return hexNumber.TrimStart('0');
;
    }
}

