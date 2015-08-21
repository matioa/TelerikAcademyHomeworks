//Problem 12. Parse URL
//    Write a program that parses an URL address given in the 
//format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ParseURL
{
    static void Main()
    {
        string URL = "http://telerikacademy.com/Courses/Courses/Details/212";

        string protocol = extractProtocol(URL);
        string server = extractServer(URL);
        string resource = extractResource(URL);
        Console.WriteLine("[protocol = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }


    private static string extractProtocol(string input)
    {
        string result = input.Substring(0, (input.IndexOf(':')));
        return result;
    }

    private static string extractServer(string input)
    {
        int startPosition = input.IndexOf("//") + 2;
        int endPosition = input.IndexOf('/', startPosition);
        string result = input.Substring(startPosition, endPosition - startPosition);
        return result;
    }

    private static string extractResource(string input)
    {
        string result = input.Remove(0, extractProtocol(input).Length + 3);
        string result2 = result.Remove(0, extractServer(input).Length);
        return result2;
    }
}
