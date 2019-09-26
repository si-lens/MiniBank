using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
namespace Infrastructure.Data.Repos
{
    class TransactionRepository : ITransactionRepository
    {
        public ITransaction AddTransactionToAccount(IAccountBank account, ITransaction transaction)
        {
            throw new NotImplementedException();
        }

        public ITransaction CreateTransaction(ITransaction transaction)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public ITransaction RemoveTransaction(ITransaction transaction)
        {
            throw new NotImplementedException();
        }

        public ITransaction RemoveTransactionFromAccount(IAccountBank account, ITransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
