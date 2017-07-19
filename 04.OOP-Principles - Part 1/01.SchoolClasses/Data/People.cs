namespace Data
{
    using System;

    public class People : Interfaces.IComentable
{
        private string firstName;

        private string lastName;

        public People()
        {
        
        }

        public People(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.lastName = value;
            }
        }
     
     public string Comment { get; set; }
    }
}
