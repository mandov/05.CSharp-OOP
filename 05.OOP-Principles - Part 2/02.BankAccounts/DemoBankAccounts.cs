using System;
using BankAccounts;

class DemoBankAccounts
{
    static void Main()
    {
        var deposit = new DepositAccount(Customer.Individual, 10000, 5);

        deposit.WithDraw(5000);
        Console.WriteLine("Deposite account balance after withdraw:{0:F2}",deposit.Balance);

        deposit.Deposit(100000);
        Console.WriteLine("Deposite account after deposit:{0:F2}", deposit.Balance);

        Console.WriteLine("Deposite account interest amount:{0}%", deposit.InterestAmount(12));

        var loan = new LoanAccount(Customer.Company, 15000, 4.5m);

        loan.Deposit(100000);
        Console.WriteLine("\nLoan account after deposit:{0:F2}", loan.Balance);

        Console.WriteLine("Loan account interest amount:{0}%", loan.InterestAmount(6));

        var mortgage = new MortgageAccount(Customer.Individual, 1000, 2.1m);

        loan.Deposit(100000);
        Console.WriteLine("\nMortgage account after deposit:{0:F2}", mortgage.Balance);

        Console.WriteLine("Loan Mortgage interest amount:{0}%", mortgage.InterestAmount(16));
    }
}