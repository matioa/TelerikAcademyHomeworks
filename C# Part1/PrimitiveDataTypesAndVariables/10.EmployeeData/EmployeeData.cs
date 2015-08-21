//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using 
//appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        string employeeFirstName = "Kiril";
        string employeeLastName = "Angov";
        byte employeeAge = 30;
        char employeeGender = 'm';
        ulong employeeEGN = 8403127606L;
        uint employeeNumber = 27569999U;
        Console.WriteLine(employeeFirstName);
        Console.WriteLine(employeeLastName);
        Console.WriteLine(employeeAge);
        Console.WriteLine(employeeGender);
        Console.WriteLine(employeeEGN);
        Console.WriteLine(employeeNumber);
    }
}
