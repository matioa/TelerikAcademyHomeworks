using System;
using System.Linq;

namespace Devices
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            Random randomGenerator = new Random();

            GSM NokiaMobile = new GSM("Lamia", "Nokia");
            GSM SamsungMobile = new GSM("Grifin", "Samsung");
            GSM HtcMobile = new GSM("Eno", "HTC");

            for (int i = 0; i < 10; i++)
            {
                DateTime callDate = DateTime.Now.AddSeconds(randomGenerator.Next(1000000));
                string mobileNumber = randomGenerator.Next(800000000, 1000000000).ToString();
                int durationInSeconds = randomGenerator.Next(3600);
                Calls someCall = new Calls(callDate, mobileNumber, durationInSeconds);
                NokiaMobile.AddCall(someCall);
            }
            NokiaMobile.DisplayCalls();

            RemoveLongestCall(NokiaMobile);

            Console.WriteLine("\n ==== Longest call removed ==== \n");

            NokiaMobile.DisplayCalls();

            NokiaMobile.DeleteCallHistory();

            Console.WriteLine("\n ==== Call History Deleted ==== \n");

            NokiaMobile.DisplayCalls();
            
        }

         private static void RemoveLongestCall(GSM phones) 
         { 
             long longestDuration = 0; 
             Calls longestCall = null; 
 

             foreach (Calls call in phones.PerformedCalls) 
             { 
                 if (call.Duratoin > longestDuration) 
                 { 
                     longestDuration = call.Duratoin; 
                     longestCall = call; 
                 } 
             } 
 

             phones.DeleteCall(longestCall); 
         } 

    }
}
