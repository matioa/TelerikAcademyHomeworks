//Problem 1. Strings in C#.



//1. Describe the strings in C#.

//A string is an object of type String whose value is text. 
//Internally, the text is stored as a sequential read-only collection of Char objects. 
//There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0'). 
//The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. 
//To access the individual Unicode code points in a string, use the StringInfo object.



//2. What is typical for the string data type?

//String objects are immutable: they cannot be changed after they have been created.
//All of the String methods and C# operators that appear to modify a string actually return the results in a new string object.  



//3. Describe the most important methods of the String class. 
//Trim()                    - Removes all leading and trailing white-space characters from the current String object
//TrimStart                 - Removes all leading occurrences of a set of characters specified in an array from the current String object.
//TrimEnd                   - Removes all trailing occurrences of a set of characters specified in an array from the current String object.
//ToUpper()                 - Returns a copy of this string converted to uppercase.
//ToLower()                 - Returns a copy of this string converted to lowercase.
//ToCharArray()             - Copies the characters in this instance to a Unicode character array. 
//ToString()                - Returns this instance of String; no actual conversion is performed. (Overrides Object.ToString().)
//Split(Char[])             - Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.
//Replace(Char, Char)       - Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.
//Remove(Int32, Int32)      - Returns a new string in which a specified number of characters in the current instance beginning at a specified position have been deleted.
//LastIndexOf(Char)         - Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance.
//IndexOfAny(Char)          - Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.
//Join(String, String[])    - Concatenates all the elements of a string array, using the specified separator between each element. 
//Insert                    - Returns a new string in which a specified string is inserted at a specified index position in this instance. 
//Contains                  - Returns a value indicating whether a specified substring occurs within this string.
//CompareTo(String)         - Compares this instance with a specified String object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified string. 

