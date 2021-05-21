using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class SavingsComposition
    {
        private Account account = new Account();


        public bool Deposit(decimal amount)
        {
            return account.Deposit(amount);
        }


        public bool Withdrawal(decimal amount)
        {
            return account.Withdrawal(amount);
        }
        
        public bool Transfer(decimal amount, Account toAccount)
        {
            return account.Transfer(amount, toAccount);
        }
        public SavingsComposition()
        {
            account = new Account();
        }





        public decimal InterestRate { get; private set; } = 0.12m;

        public decimal CalculateInterestByMonths(int NumberOfMonths)
        {
            return account.Balance * (InterestRate / 12.0m) * NumberOfMonths;
        }

        public void PayInterest(int NumberOfMonths)
        {
            var interest = CalculateInterestByMonths(NumberOfMonths);
            Deposit(interest);
        }

    }
}
