namespace GSM.Components
{
    using System;

    public class Call
    {
        private DateTime date;
        private string time;
        private int callDuration;

        public Call()
            : this(default(DateTime), null, 0)
        {
        }

        public Call(DateTime date, string time, int callDuration)
        {
            this.date = date;
            this.time = time;
            this.callDuration = callDuration;
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public int CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }
    }
}
