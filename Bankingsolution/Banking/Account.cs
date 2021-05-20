﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public string RoutingNumber { get; set; }
        public string Description { get; set; }

        public bool Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine($"the amount must be greater than zero");
                return false;
            }                    
            Balance = Balance + amount;
            return true;
        }

        public bool Withdrawal(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"the amount must be greater than zero");
                return false;
            }
            if(amount > Balance)
            {
                Console.WriteLine($"Insufficient Funds");
                return false;
            }
            Balance = Balance - amount;
            return true;
        }

        public bool Transfer(decimal amount, Account toAccount)
        {
            var success = Withdrawal(amount);
            if (success == true)
            {                
                toAccount.Deposit(amount);
                return true;
            }
            return false;
            
        }



    }
}
