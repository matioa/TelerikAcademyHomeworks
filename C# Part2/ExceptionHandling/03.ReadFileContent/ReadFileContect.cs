﻿//Problem 3. Read file contents

//    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//    Find in MSDN how to use System.IO.File.ReadAllText(…).
//    Be sure to catch all possible exceptions and print user-friendly error message

using System;
using System.IO;

class ReadFileContect
{
    static void Main()
    {
        Console.Write("Enter full path to the file: ");
        string filePath = Console.ReadLine();
        ReadFile(filePath);
    }

    static void ReadFile(string filePath)
    {
        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("Printing the content: ");
            Console.WriteLine(fileContent);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}

