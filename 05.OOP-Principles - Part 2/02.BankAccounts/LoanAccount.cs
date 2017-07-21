using System;

namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
        : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmount(int months)
        {

            if ((this.Customer == Customer.Individual && months == 3))
            {
                Console.WriteLine("Loan accounts have no interest for the first 3 months if are held by individuals");
                return this.InterestRate;
            }

            if ((this.Customer == Customer.Company && months == 2))
            {
                Console.WriteLine("Loan accounts have no interest for the first 2 months if are held by company");
                return this.InterestRate;
            }

            decimal result = months * this.InterestRate;

            return result;
        }
    }
}