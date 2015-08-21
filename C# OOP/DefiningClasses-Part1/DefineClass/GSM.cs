
namespace Devices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private static GSM iPhone4s = new GSM("4s", "Apple", 1200, new Battery(BatType.LiIon, 500, 100), new Display(4, 16000000));
        private const double pricePerMinute = 0.37;

        private double price;
        private List<Calls> performedCalls = new List<Calls>();

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Battery = new Battery();
            this.Display = new Display();
        }

        public GSM(string model, string manufacturer, double price, Battery addBattery, Display addDisplay)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Battery = addBattery;
            this.Display = addDisplay;
        }


        public static GSM IPhone4s
        {
            get
            {
                return iPhone4s;
            }
        }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot negative!");
                }
                this.price = value;
            }
        }

        public string Owner { get; set; }

        public Battery Battery { get; private set; }

        public Display Display { get; private set; }

        public List<Calls> PerformedCalls
        {
            get
            {
                return this.performedCalls;
            }
            private set
            {
                this.performedCalls = value;
            }
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Model: {0}", this.Model);
            Console.WriteLine("Manufacturer: {0}", this.Manufacturer);
            Console.WriteLine("Price: {0}", this.Price);
            Console.WriteLine("Owner: {0}", this.Owner);
            Console.WriteLine("Battery type: {0}", this.Battery.BatteryType);
            Console.WriteLine("Battery idle time : {0}", this.Battery.HoursIdle);
            Console.WriteLine("Battery talk time : {0}", this.Battery.HoursTalk);
            Console.WriteLine("Display size (in inches) : {0}", this.Display.Size);
            Console.WriteLine("Display colors : {0}", this.Display.NumberOfColors);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append("Model: " + this.Model + "\n");
            text.Append("Manufacturer: " + this.Manufacturer + "\n");
            text.Append("Price: " + this.Price + "\n");
            text.Append("Owner: " + this.Owner + "\n");
            text.Append("Battery idle time: " + this.Battery.HoursIdle + "\n");
            text.Append("Battery talk time: " + this.Battery.HoursTalk + "\n");
            text.Append("Display size (inches): " + this.Display.Size + "\n");
            text.Append("Display colors: " + this.Display.NumberOfColors + "\n");
            return text.ToString(); ;
        }

        public void AddCall(Calls call)
        {
            this.PerformedCalls.Add(call);
        }

        public void DeleteCall(Calls call)
        {
            this.PerformedCalls.Remove(call);
        }

        public void DeleteCallHistory()
        {
            this.PerformedCalls.Clear();
        }

        public double CallPrice(double pricePerMinute)
        {
            double sum = 0;
            foreach (var call in this.PerformedCalls)
            {
                int callDurationInMinutes = 0;
                if (call.Duratoin % 60 == 0) // Round up every started minute in order to calculate the price (the way the GSM operator does)
                {
                    callDurationInMinutes = (int)(call.Duratoin / 60);
                }
                else
                {
                    callDurationInMinutes = (int)(call.Duratoin / 60) + 1;
                }
                sum += callDurationInMinutes * pricePerMinute;
            }

            return sum;
        }

        public void DisplayCalls()
        {
            int counter = 1;
            foreach (var call in this.PerformedCalls)
            {
                Console.WriteLine("----Call {0}----", counter);
                Console.WriteLine("Mobile number: +359{0}", call.PhoneNumber);
                Console.WriteLine("Date: {0: dd/MM/yyy HH:mm:ss}", call.Date);
                Console.WriteLine("Duration: {0} min, {1} sec", (int)call.Duratoin / 60, call.Duratoin % 60);
                counter++;
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(string.Format("price: {0}", this.CallPrice(pricePerMinute)));
        }
    }
}
