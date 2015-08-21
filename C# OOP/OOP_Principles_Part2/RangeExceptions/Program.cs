using System;

namespace RangeExceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                Numbers oneNumber = new Numbers(300);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0} \nmin:{1} \nmax:{2}",ex.Message,ex.Min,ex.Max);
            }

            Console.WriteLine();

            try
            {
                Dates aDate = new Dates(new DateTime(2014,3,31));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("{0} \nmin:{1} \nmax:{2}", ex.Message, ex.Min, ex.Max);
            }
        }
    }
}
