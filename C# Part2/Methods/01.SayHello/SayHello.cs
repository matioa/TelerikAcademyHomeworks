//Problem 1. Say Hello
//• Write a method that asks the user for his name and prints  “Hello, <name>”  
//• Write a program to test this method.


using System;

class SayHello
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string input = Console.ReadLine();
        PrintName(input);
        
    }

    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}

