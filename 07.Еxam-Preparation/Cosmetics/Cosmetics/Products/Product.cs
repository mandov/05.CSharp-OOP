namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product name is null or empty !");
                }

                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException("Product name must be between 3 and 10 symbols long!");
                }

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product brand is null or empty !");
                }

                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Product brand must be between 2 and 10 symbols long!");
                }

                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be greater than 0!");
                }
              
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
            }
        }

        public string Print()
        {          
            return string.Format(
               "- {0} – {1}:\n * Price: ${2:F2}\n * For gender: {3}",
               this.brand,
               this.name,
               this.price,
               this.gender);
        }
    
    }
}