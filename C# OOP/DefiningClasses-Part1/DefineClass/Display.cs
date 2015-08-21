
namespace Devices
{
    using System;

    public class Display
    {
        private double size;
        private long numberOfColors;


        public Display()
        {
        }

        public Display(double size, long numColors)
        {
            this.Size = size;
            this.NumberOfColors = numColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative!");
                }
                this.size = value;
            }
        }

        public long NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative!");
                }
                this.numberOfColors = value;
            }
        }
    }
}
