namespace GSM.Components
{
    public class Battery
    {
        private BatteryType batteryModel;
        private int hoursIdle;
        private int hoursTalk;

        public Battery()
            : this(new BatteryType(), 0, 0)
        {
        }

        public Battery(BatteryType batteryModel, int hoursIdle, int hoursTalk)
        {
            this.batteryModel = batteryModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("This value is invalid");
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
                    throw new System.ArgumentException("This value is invalid");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType MyProperty
        {
            get
            {
                return this.batteryModel;
            }
        }

        public override string ToString()
        {
            return "BatteryType:" + this.batteryModel + " " + "HoursIdle:" + this.hoursIdle + " " + "HoursTalk:" + this.hoursTalk;
        }
    }
}