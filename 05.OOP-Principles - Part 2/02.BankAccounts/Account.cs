namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        private Customer customer;

        private decimal balance;

        private decimal interestRate;

        public Account()
        {
        }

        public Account(Customer costumer, decimal balance, decimal interestRate)
        {
            this.customer = costumer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public void Deposit(decimal amount)
        {
            while (amount <= 0)
            {
                Console.WriteLine("You need to enter number that is greater than zero !");
                amount = decimal.Parse(Console.ReadLine());
            }
           
            this.Balance += amount;
        }

        public abstract decimal InterestAmount(int months);

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Amount must be greater than zero !");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Amount must be greater than zero !");
                }

                this.interestRate = value;
            }
        }

        public Customer Customer
        {
            get { return this.customer; }
        }
    }
}
