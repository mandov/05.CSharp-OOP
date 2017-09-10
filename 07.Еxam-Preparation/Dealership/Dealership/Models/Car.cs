namespace Dealership.Models
{
    using Dealership.Common;
    using Dealership.Contracts;

    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            this.Seats = seats;
            this.wheels = 4;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }

            set
            {
                Validator.ValidateIntRange(
                    value,
                    Constants.MinSeats,
                    Constants.MaxSeats,
                   string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats", Constants.MinSeats, Constants.MaxSeats));

                this.seats = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(
                "Seats: {0} \n   {1} \n {2}   {3}",
                this.Seats,
                this.Comments.Count == 0 ? " --NO COMMENTS--" : " --COMMENTS--",
                string.Join(string.Empty, this.Comments),
                this.Comments.Count != 0 ? " --COMMENTS--" : "").Trim();
        }
    }
}