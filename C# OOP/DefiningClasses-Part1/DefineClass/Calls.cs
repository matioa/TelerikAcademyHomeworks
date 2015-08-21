namespace Devices
{
    using System;

    public class Calls
    {
        private DateTime date;
        private string phoneNumber;
        private long duration;

        
        public Calls(DateTime dateAndTime, string calledNumber, long callDuration)
        {
            this.Date = dateAndTime;
            this.PhoneNumber = calledNumber;
            this.Duratoin = callDuration;
        }

        public DateTime Date { get; private set; }

        public string PhoneNumber { get; set; }

        public long Duratoin { get; set; }
    }
}
