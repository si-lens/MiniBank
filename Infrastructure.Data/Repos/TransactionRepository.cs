using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
namespace Infrastructure.Data.Repos
{
    class TransactionRepository : ITransactionRepository
    {
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

        public void RemoveTransactionFromAccount(IAccountBank account, ITransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
