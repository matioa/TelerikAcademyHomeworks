namespace Students
{
    using System;
    using System.Collections.Generic;

    public class Marks
    {
        private double mark;

        public Marks(double someMark)
        {
            this.Mark = someMark;
        }

        public double Mark
        {
            get
            {
                return this.mark;
            }
            set
            {
                if (value < 1 || value >6)
                {
                    throw new ArgumentOutOfRangeException("Mark should be between 1 and 6");
                }
                this.mark = value;
            }
        }
    }
}
