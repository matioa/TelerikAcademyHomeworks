using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VariablePrinter
{
    private const int MAX_COUNT = 6;
    public class Printer
    {
        public void convertBoolToString(bool input)
        {
            string output = input.ToString();
            Console.WriteLine(output);
        }
    }
    public static void EntryPoint()
    {
        VariablePrinter.Printer print = new VariablePrinter.Printer();
        print.convertBoolToString(true);
    }
}

