
namespace Devices
{
    using System;

    public class Battery
    {
        private int hoursIdle;
        private int hoursTalk;

        public Battery()
        { 
        }

        public Battery(BatType batteryType, int hoursIdle, int hoursTalk)
        {
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatType BatteryType {get; private set;}

        public int HoursIdle
        {
            get 
            { 
                return this.hoursIdle;
            }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative!");   
                }
                this.hoursIdle = value;
            }
        }


        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative!");
                }
                this.hoursTalk = value;
            }
        }
    }
}
