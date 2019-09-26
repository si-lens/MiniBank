using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.DomainService
{
    public interface ITransactionRepository
    {
        ITransaction CreateTransaction(ITransaction transaction);
        ITransaction RemoveTransaction(ITransaction transaction);
        ITransaction AddTransactionToAccount(IAccountBank account, ITransaction transaction);
        ITransaction RemoveTransactionFromAccount(IAccountBank account, ITransaction transaction);
        IEnumerable<ITransaction> GetAllTransactions();
    }
}
