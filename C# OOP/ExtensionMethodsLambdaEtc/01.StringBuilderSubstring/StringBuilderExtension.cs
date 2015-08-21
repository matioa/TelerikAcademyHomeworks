
namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class SomeExtensions
    {
        public static string MySubstring(this string input, int start, int length)
        {
            StringBuilder result = new StringBuilder();
            char[] inputAsChars = input.ToCharArray();

            if (start<0 || start >input.Length || (start+length)>input.Length)
            {
                throw new IndexOutOfRangeException();   
            }

            for (int i = start; i < start+length; i++)
            {
                result.Append(inputAsChars[i]);
            }
            return result.ToString();
        }

        public static string MySubstring(this string input, int start)
        {
            StringBuilder result = new StringBuilder();
            char[] inputAsChars = input.ToCharArray();

            if (start < 0 || start > input.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = start; i < inputAsChars.Length; i++)
            {
                result.Append(inputAsChars[i]);
            }
            return result.ToString();
        }
    }
}
