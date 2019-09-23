using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.DomainService
{
    public interface ITransactionRepository
    {
        ITransaction CreateTransaction();
        void RemoveCustomer(ITransaction customer);
        void AddTransactionToAccount(IAccountBank account, ITransaction transaction);
        void RemoveTransactionFromAccount(IAccountBank account, ITransaction transaction);
        List<ITransaction> GetAllTransactions();
    }
}
