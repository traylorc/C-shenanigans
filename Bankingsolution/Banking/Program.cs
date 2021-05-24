using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var sv1 = new SavingsComposition();
            sv1.Deposit(2000);
            var cd10 = new CD_composition(5000, 60);
            var accounts = new IBanking[] { sv1, cd10 };
            foreach(var acct in accounts)
            {
                Console.WriteLine($"Account balance is {acct.GetBalance()}");
            }


            var sav1 = new Savings();
            sav1.Deposit(1000);
            sav1.PayInterest(3);



            var account1 = new Account();
            account1.Deposit(500);
            account1.Withdrawal(100);
            account1.Deposit(200);

            Console.WriteLine($"Balance is {account1.Balance}");


            var account2 = new Account();
            account1.Transfer(400, account2);
            Console.WriteLine($"Balance is {account1.Balance}");
            Console.WriteLine($"Balance is {account2.Balance}");



        }
    }
}
