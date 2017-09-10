namespace FurnitureManufacturer
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Models;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.MaterialType = material;
            this.Price = price;
            this.Height = height;
        }

        public virtual string Model
        {
            get
            {
                return this.model;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty or null");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be less than 3 symbols");
                }

                this.model = value;
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
                    throw new ArgumentException("Price cannot be less or equal to $0.00.");
                }

                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less or equal to 0.00 m.");
                }

                this.height = value;
            }
        }
     
        public string Material
        {
            get
            {
                return this.MaterialType.ToString();
            }

            protected set
            {
                this.Material = value;
            }
        }

        protected MaterialType MaterialType { get; set; }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
