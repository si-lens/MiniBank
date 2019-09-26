using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
    public class Transaction
    {
        public enum TransactionType { Deposit, Loan, Transfer, Withdrawal };
        int Id { get; set; }
        DateTime Date {get; set;}

        string Description { get; set; }

        double Amount { get; set; }
    }
}
