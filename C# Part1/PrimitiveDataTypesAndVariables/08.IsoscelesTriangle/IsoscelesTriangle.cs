//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and 
//assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        int numberOfRows = 15; //CHANGE the nubmer of rows to make the triangle bigger
        Console.OutputEncoding = Encoding.Unicode;
        char printSign = '\u00a9';
        for (int i=0; i< numberOfRows-1; i++) //draw the number of rows needed
        {
            for (int j = numberOfRows-1-i; j > 0; j--) // draw empty spaces on the left of the triangle
        	{
	        	Console.Write(" ");
	        }
            Console.Write(printSign); //draw starting signg at each row
            for (int j = 0; j < i*2-1; j++) //draw spaces to fill the inside of the triangle
        	{
	            Console.Write(" ");
        	}
            if (i >=1) //Draw ending sign for each roll (skipping the first/0 line)
            {
                    Console.Write(printSign);
            }
            Console.WriteLine(); //Draw a new line before starting the row loop again
        }
        for (int i=1; i<=numberOfRows;i++)    //Draw the last row to finish the triangle 
        {
            Console.Write("{0} ", printSign);
        }
        Console.WriteLine();
        Console.WriteLine(); // finish the trianle with two new lines
    }
}