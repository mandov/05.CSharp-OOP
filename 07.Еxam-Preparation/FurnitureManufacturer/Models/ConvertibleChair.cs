namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool convertOrNot = false;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public bool IsConverted
        {
            get { return this.convertOrNot; }
        }

        public override decimal Height
        {
            get
            {
                if (this.convertOrNot)
                {
                    return 0.10m;
                }
                else
                {
                    return base.Height;
                }
            }
        }

        public void Convert()
        {
            this.convertOrNot = !this.convertOrNot;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
