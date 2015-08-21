﻿//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company Address: ");
        string companyAddress= Console.ReadLine();
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax Number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Manager Phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}",phoneNumber);
        Console.WriteLine("Fax: {0}",faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName, lastName, age, managerPhone);
}
}

