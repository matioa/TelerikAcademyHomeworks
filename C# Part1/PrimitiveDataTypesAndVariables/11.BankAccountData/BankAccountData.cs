//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string clientFirstName = "Kiril";
        string clientMiddleName = "Metodiev";
        string clientLastName = "Angov";
        decimal accountBalance = 109573.53M;
        string bankName = "Terlik Bank";
        string IBAN = "BG60TRK2929488477444";
        ulong creditCardVisa = 475612348769998;
        ulong creditCardMasterCard = 668944990387634;
        ulong creditCardAmex = 375500329076532;

        Console.WriteLine("Client's name: {0} {1} {2}",clientFirstName, clientMiddleName,clientLastName);
        Console.WriteLine("Client's bank: {0}", bankName);
        Console.WriteLine("Client's account balance: {0}",accountBalance);
        Console.WriteLine("Client's IBAN: {0}",IBAN);
        Console.WriteLine("Visa credit card: {0}",creditCardVisa);
        Console.WriteLine("MasterCard credit card: {0}", creditCardMasterCard);
        Console.WriteLine("American Express credit card: {0}",creditCardAmex);
        Console.WriteLine();
    }
}
