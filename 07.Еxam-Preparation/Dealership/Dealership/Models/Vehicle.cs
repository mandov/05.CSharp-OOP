namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using Dealership.Common;
    using Dealership.Common.Enums;
    using Dealership.Contracts;

    public abstract class Vehicle : IVehicle
    {
        protected int wheels;
        private VehicleType type;
        private string make;
        private string model;
        private IList<IComment> comments;
        private decimal price;

        public Vehicle(string make, string model, decimal price)
        {
            this.comments = new List<IComment>();
            this.Make = make;
            this.Model = model;
            this.Price = price;           
        }

        public  int Wheels
        {
            get
            {
                return this.wheels;
            }   
        }

        public VehicleType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }

            set
            {
                Validator.ValidateNull(value, "Make must not be null!");

                if (value.Length < Constants.MinMakeLength || value.Length > Constants.MaxMakeLength)
                {
                    throw new ArgumentException(string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                }

                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                Validator.ValidateNull(value, "Model must not be null!");
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinModelLength, 
                    Constants.MaxModelLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));

                this.model = value;
            }
        }

        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                this.comments = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                Validator.ValidateDecimalRange(
                    value, 
                    Constants.MinPrice,
                    Constants.MaxPrice,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}:\n  Make: {1}\n  Model: {2}\n  Wheels: {3}\n  Price: ${4}\n  ", GetType().Name, this.Make, this.Model, this.Wheels, this.Price);
        }
    }
}