namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(T min,T max)
            :base(string.Format("You need to enter numbers in this range[{0}-{1}]",min,max))
        {
            this.Max = max;
            this.Min = min;
        }

        public T Max { get; private set; }

        public T Min { get; private set; }
    }
}