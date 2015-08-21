﻿//Problem 15. Replace tags
//    Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReplaceTags
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        StringBuilder textNew = new StringBuilder(text);

        string[] textOut = {"<a href=\"",
                               "\">",
                               "</a>"};
        string[] textIn = {"[URL=",
                              "]",
                              "[/URL]"};


        for (int i = 0; i < textOut.Length; i++)
        {
            textNew.Replace(textOut[i], textIn[i]);
        }

        Console.WriteLine(textNew);
    }
}

