using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService.ApplicationService.Impl
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository transactionRepo;

        public TransactionService(ITransactionRepository transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }

        public void AddTransactionToAccount(IAccountBank account, ITransaction transaction)
        {
            throw new NotImplementedException();
        }

        public ITransaction CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public List<ITransaction> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(ITransaction customer)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransaction(ITransaction customer)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransactionFromAccount(IAccountBank account, ITransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
