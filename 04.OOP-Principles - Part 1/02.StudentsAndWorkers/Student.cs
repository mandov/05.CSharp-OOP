﻿namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("You must enter positive number !");
                }
                this.grade = value;
            }
        }
    }
}
