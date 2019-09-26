using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniBank.Core.ApplicationService.ApplicationService.Impl
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository transactionRepo;

        public TransactionService(ITransactionRepository transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }

        public Transaction AddTransactionToAccount(Account account, Transaction transaction)
        {
            return transactionRepo.AddTransactionToAccount(account, transaction);
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            return transactionRepo.CreateTransaction(transaction);
        }

        public List<Transaction> GetAllTransactions()
        {
            return transactionRepo.GetAllTransactions().ToList();
        }

   

        public Transaction RemoveTransaction(Transaction transaction)
        {
            return transactionRepo.RemoveTransaction(transaction);
        }

        public Transaction RemoveTransactionFromAccount(Account account, Transaction transaction)
        {
            return transactionRepo.RemoveTransactionFromAccount(account, transaction);
        }
    }
}
