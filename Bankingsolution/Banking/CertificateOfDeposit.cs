using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class CertificateOfDeposit : Account
    {
        public DateTime DepositDate { get; set; } = DateTime.Now;
        public DateTime WithdrawDate { get; set; }
        public decimal InterestRate { get; set; }
        private int Months { get; set; }

        public override bool Deposit(decimal amount)
        {
            Console.WriteLine("Cannot call deposit() on a CD");
            return false;
        }
        public override bool Withdrawal(decimal amount)
        {
            Console.WriteLine("Call Withdraw() after WithdrawDate to recieve all funds");
            return false;
        }
        public bool Withdrawal()
        {
            if(DateTime.Now < WithdrawDate)
            {
                Console.WriteLine("Cannot withraw funds from CD till {WithdrawDate.ToString(MM/dd/yyyy)} ");
                return false;
            }
            return base.Withdrawal(Balance);

        }
        private void CalcAndPayInterestOnDeposit()
        {
            var interest = Balance * (InterestRate / 12) * Months;
            base.Deposit(decimal.Round(interest, 2));
        }

        private void SetDurationAndRate(int months)
        {
            switch(months)
            {
                case 12:
                    WithdrawDate = DepositDate.AddYears(1);
                    InterestRate = 0.01m;
                    break;
                case 24:
                    WithdrawDate = DepositDate.AddYears(2);
                    InterestRate = 0.02m;
                    break;
                case 36:
                    WithdrawDate = DepositDate.AddYears(3);
                    InterestRate = 0.03m;
                    break;
                case 48:
                    WithdrawDate = DepositDate.AddYears(4);
                    InterestRate = 0.04m;
                    break;
                case 60:
                    WithdrawDate = DepositDate.AddYears(5);
                    InterestRate = 0.05m;
                    break;
                default:
                    break;
            }

            public CertificateOfDeposit(decimal Amount, int Months)
            {
                this.Months = Months;
                    SetDurationAndRate(Months);
                var success = base.Deposit(Amount);
                CalcAndPayInterestOnDeposit();
            }
        }
    }
}
