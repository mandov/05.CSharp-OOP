namespace Dealership.Models
{
    using System;
    using Dealership.Common;
    using Dealership.Contracts;

    public class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            this.Category = category;
            this.wheels = 2;
        }

        public string Category
        {
            get
            {
                return this.category;
            }

            set
            {
                Validator.ValidateNull(value, "Category can not be null!");
                if (value.Length < Constants.MinCategoryLength || value.Length > Constants.MaxCategoryLength)
                {
                    throw new ArgumentException(string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
                }

                this.category = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(
                "Category: {0}\n   {1}\n{2}   {3}",
                this.Category,
                this.Comments.Count == 0 ? " --NO COMMENTS--" : " --COMMENTS--",
                string.Join(string.Empty, this.Comments),
                this.Comments.Count != 0 ? " --COMMENTS--" : "").Trim();
        }
    }
}
