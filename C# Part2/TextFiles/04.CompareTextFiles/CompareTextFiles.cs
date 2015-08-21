//Problem 4. Compare text files
//    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//    Assume the files have equal number of lines.


using System;
using System.IO;
class CompareTextFiles
{
    static void Main()
    {

        StreamReader reader1 = new StreamReader(@"../../Sample1.txt");
        StreamReader reader2 = new StreamReader(@"../../Sample2.txt");

        int countEqual = 0;
        int countNotEqual = 0;

        using (reader1)
        {
            using (reader2)
            {
                string fileContent1 = reader1.ReadLine();
                string fileContent2 = reader2.ReadLine();

                while (fileContent1 != null)
                {
                    if (fileContent1.CompareTo(fileContent2) == 0)
                    {
                        countEqual++;
                    }
                    else
                    {
                        countNotEqual++;
                    }
                    fileContent1 = reader1.ReadLine();
                    fileContent2 = reader2.ReadLine();
                }
            }
        }
        Console.WriteLine("Equal lines: {0}", countEqual);
        Console.WriteLine("Diff. lines: {0}", countNotEqual);
        Console.WriteLine("Total lines: {0}", countEqual+countNotEqual);
}
}

