namespace StudentsAndWorkers
{
    using System;

  public  class Worker : Human
    {
        private int weekSalary;

        private int workHoursPerDay;

        public Worker(string firstName, string lastName,int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("You need to enter positive nubmer !");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("You need to enter positive nubmer !");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = (decimal)weekSalary / (workHoursPerDay * 5);
            return result;
        }
    }
}
