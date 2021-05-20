using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
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
