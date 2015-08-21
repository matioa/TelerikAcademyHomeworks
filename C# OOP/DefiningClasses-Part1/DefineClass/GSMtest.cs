using System;

namespace Devices
{
    class GSMtest
    {
        static void Main()
        {
            GSM[] mobileDevices = 
            {
                new GSM("One","HTC"),
                new GSM("MotoG","Motorolla",550.50,new Battery(BatType.LiIon,500,50),new Display(4.5,16000000)),
                new GSM("Samsuniak", "Samsung")
            };

            foreach (var mobile in mobileDevices)
            {
                mobile.DisplayInfo();
                Console.WriteLine(new string('-',30));
            }
            Console.WriteLine(GSM.IPhone4s);


        }
    }
}
