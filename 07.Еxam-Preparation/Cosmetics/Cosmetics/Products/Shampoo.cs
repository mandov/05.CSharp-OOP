namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;       

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Price = this.Price * milliliters;
            this.milliliters = milliliters;
            this.usage = usage;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }

            set
            {
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }

            set
            {
                this.usage = value;
            }
        }

        public override string ToString()
        {
            return Print() + string.Format(
                "\n * Quantity: {0}ml\n * Usage: {1}",
                this.milliliters,
                this.usage);
        }
    }
}