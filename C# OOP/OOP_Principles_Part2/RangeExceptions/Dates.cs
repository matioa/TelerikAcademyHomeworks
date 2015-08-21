
namespace RangeExceptions
{
    using System;
    public class Dates
    {
        private DateTime date;

        public Dates(DateTime someDate)
        {
            this.Date = someDate;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value < new DateTime(1980, 1, 1) || value > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Date is out of range", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));   
                }
                this.date = value;
            }
        }
    }
}
