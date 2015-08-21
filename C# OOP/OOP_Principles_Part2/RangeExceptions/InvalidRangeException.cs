namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : Exception
    {
        public InvalidRangeException(string message, T min, T max)
        {
            this.Message = message;
            this.Min = min;
            this.Max = max;

        }
        public string Message { get; set; }
        public T Min { get; set; }
        public T Max { get; set; }
    }
}
