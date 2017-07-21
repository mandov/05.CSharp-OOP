namespace BankAccounts
{
    using System;
    using BankAccounts.Interfaces;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
        : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmount(int months)
        {
            if (this.Balance < 1000)
            {
                Console.WriteLine("There is no Interest amount if your balance is under 1000 !");
                return this.InterestRate;
            }
            return months * InterestRate;
        }

        public void WithDraw(decimal amount)
        {

            while (amount <= 0)
            {
                Console.WriteLine("You need to enter number that is greater than zero !");
                amount = decimal.Parse(Console.ReadLine());
            }

            while (this.Balance < amount)
            {
                Console.WriteLine("You don't have enough balance, please enter new mooney amount");
                amount = decimal.Parse(Console.ReadLine());
            }

            this.Balance -= amount;
        }
    }
}