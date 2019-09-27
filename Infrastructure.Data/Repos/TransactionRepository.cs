using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
namespace Infrastructure.Data.Repos
{
    class TransactionRepository : ITransactionRepository
    {

        private MiniBankContext context;

        public TransactionRepository(MiniBankContext ctx)
        {
            context = ctx;
        }
        public Transaction AddTransactionToAccount(Account account, Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public Transaction RemoveTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Transaction RemoveTransactionFromAccount(Account account, Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
