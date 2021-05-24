using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    interface IBanking
    {
        decimal GetBalance();
        string GetAccountNumber();
    }
}
