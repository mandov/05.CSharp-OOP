namespace Dealership.Models
{
    using Dealership.Common;
    using Dealership.Contracts;

    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
            this.wheels = 8;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }

            set
            {
                Validator.ValidateIntRange(
                    value,
                    Constants.MinCapacity,
                    Constants.MaxCapacity,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity));

                this.weightCapacity = value;
            }
        }
              
        public override string ToString()
        {
            return base.ToString() + string.Format(
                "  Weight Capacity: {0}t\n {1}\n{2}   {3}", 
                this.WeightCapacity,
                this.Comments.Count == 0 ? " --NO COMMENTS--" : " --COMMENTS--",
                string.Join(string.Empty, this.Comments).Trim(),
                this.Comments.Count != 0 ? " --COMMENTS--" : "");
        }
    }
}
