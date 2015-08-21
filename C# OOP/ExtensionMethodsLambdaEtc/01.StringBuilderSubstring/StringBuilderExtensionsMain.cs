using System;

namespace _01.StringBuilderSubstring
{
    class StringBuilderExtensionsMain
    {
        static void Main()
        {
            //Problem 1
            string text = "This is some test text.";
            string partWithMyString = text.MySubstring(3, 3);
            string anotherPartWithMyString = text.MySubstring(2);
            string partWithSubstring = text.Substring(3, 3);

            Console.WriteLine(partWithMyString);
            Console.WriteLine(anotherPartWithMyString);
            Console.WriteLine(partWithSubstring);
            
            
            
        }
    }
}
