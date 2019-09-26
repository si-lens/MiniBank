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

        public ITransaction AddTransactionToAccount(IAccountBank account, ITransaction transaction)
        {
            return transactionRepo.AddTransactionToAccount(account, transaction);
        }

        public ITransaction CreateTransaction(ITransaction transaction)
        {
            return transactionRepo.CreateTransaction(transaction);
        }

        public List<ITransaction> GetAllTransactions()
        {
            return transactionRepo.GetAllTransactions().ToList();
        }

   

        public ITransaction RemoveTransaction(ITransaction transaction)
        {
            return transactionRepo.RemoveTransaction(transaction);
        }

        public ITransaction RemoveTransactionFromAccount(IAccountBank account, ITransaction transaction)
        {
            return transactionRepo.RemoveTransactionFromAccount(account, transaction);
        }
    }
}
