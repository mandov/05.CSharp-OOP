namespace Data
{
    using System;

    public class Student : People
    {
        private int classNumber;

        public Student ()
        {

        }

        public Student (string firstName,string lastName,int classNumber)
            :base(firstName,lastName)
        {
            if (classNumber <= 0)
            {
                throw new ArgumentException("Class Number must be positive !!!");
            }

            if (firstName.Length == 0)
            {
                throw new ArgumentException("You need to enter valid first name !");
            }

            if (lastName.Length == 0)
            {
                throw new ArgumentException("You need to enter valid last name !");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.classNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.classNumber;
        }
    }
}
