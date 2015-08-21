namespace RangeExceptions
{
    public class Numbers
    {
        private int number;

        public Numbers(int someNumber)
        {
            this.Number = someNumber;
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if (value <1 || value >100)
                {
                 throw new InvalidRangeException<int>("Number is out of range",1,100);   
                }
                this.number = value;
            }
        }
    }
}
