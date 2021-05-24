﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class CD_composition : IBanking
    {
        private Account account = new Account();
     

        public DateTime DepositDate { get; private set; } = DateTime.Now;
        public DateTime WithdrawDate { get; set; }

        public bool Withdraw()
        {
            if(DateTime.Now < WithdrawDate)
            {
                Console.WriteLine("Cannot withdraw till WithdrawDate");
                return false;
            }
            return account.Withdrawal(account.Balance);
        }

        public decimal GetBalance()
        {
            return account.Balance;
        }

        public string GetAccountNumber()
        {
            return account.AccountNumber;
        }

        public CD_composition(decimal Amount, int Months)
        {
            var success = account.Deposit(Amount);
            var interestRate = 0.0m;
            
            switch(Months)
            {
                case 12: interestRate = 0.01m; break;
                case 24: interestRate = 0.02m; break;
                case 36: interestRate = 0.03m; break;
                case 48: interestRate = 0.04m; break;
                case 60: interestRate = 0.05m; break;
                default: break;
            }
            var interest = account.Balance * (interestRate / 12) * Months;
            success = account.Deposit(interest);
            WithdrawDate = DepositDate.AddMonths(Months);

        }
    }
}
