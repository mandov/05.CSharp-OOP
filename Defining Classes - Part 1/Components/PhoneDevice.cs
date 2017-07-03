namespace GSM.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PhoneDevice
    {
        private const double PricePerMinute = 0.37;
        private static PhoneDevice iPhone4S = new PhoneDevice("iPhone 6s", "Apple", 1000, "Darko");
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public PhoneDevice(string model, string manufacturer)
            : this(model, manufacturer, 0, string.Empty, new Battery(), new Display())
        {
        }

        public PhoneDevice(string model, string manufacturer, int price, string owner)
            : this(model, manufacturer, price, owner, new Battery(), new Display())
        {
        }

        public PhoneDevice(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public static PhoneDevice IPhone4S { get => iPhone4S; set => iPhone4S = value; }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value == null)
                {
                    throw new System.ArgumentException("You need to set a model");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value == null)
                {
                    throw new System.ArgumentException("You need to set a manufacturer");
                }

                this.manufacturer = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("You need to set valid price");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value ?? throw new System.ArgumentException("You need to set valid name");
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

            set
            {
                this.callHistory = value;
            }
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public double CalculateTotalPrice()
        {
            double result = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                result += this.callHistory[i].CallDuration;
            }

            result = (result / 60) * PricePerMinute;
            return result;
        }

        public string ReturnAllCallHistory()
        {
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                st.AppendFormat("Call Date:{0} Call Duration:{1} Time:{2}\n", this.callHistory[i].Date.ToShortDateString(), this.callHistory[i].CallDuration, this.callHistory[i].Time);
            }

            return st.ToString();
        }

        public void RemoveLongestCall()
        {
            int index = 0;
            int longestCall = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (this.callHistory[i].CallDuration > longestCall)
                {
                    longestCall = this.callHistory[i].CallDuration;
                    index = i;
                }
            }

            this.callHistory.RemoveAt(index);
        }

        public override string ToString()
        {
            return "Model:" + this.model + " " + "Price:" + this.price +
                " " + "Owner:" + this.owner + " " + "Battery:" + this.battery + " " + "\nDisplay:" + this.display + "Manufacturer:" + this.manufacturer;
        }
    }
}