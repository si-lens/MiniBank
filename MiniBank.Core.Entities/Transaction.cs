using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
    public class Transaction
    {

        public int Id { get; set; }
        public DateTime Date {get; set;}

        public string Description { get; set; }

        public double Amount { get; set; }
        public enum TransactionType { Deposit, Loan, Transfer, Withdrawal };

        public TransactionType transactionType { get; }

        public Transaction()
        {
        }
        public Transaction(int id, DateTime date, double amount, TransactionType _transactionType)
        {
            Id = id;
            Date = date; 
            Amount = amount;
            transactionType = _transactionType;
        }
    }
}
