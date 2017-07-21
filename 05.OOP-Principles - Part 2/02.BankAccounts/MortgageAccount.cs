using System;

namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
        : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmount(int months)
        {
            if (months <= 12 && this.Customer == Customer.Company)
            {
                return (this.InterestRate / 2) * months;
            }

            if (months <= 6 && this.Customer == Customer.Individual)
            {
                Console.WriteLine("There is no Interest amount for first six months when customer is Individual !");
                return this.InterestRate;
            }

            return this.InterestRate * months;
        }
    }
}