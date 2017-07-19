namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string fistName;

        private string lastName;

        public Human(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("You must enter name");
            }

            this.fistName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return this.fistName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public override string ToString()
        {
            return this.fistName + " " + this.lastName;
        }
    }
}
