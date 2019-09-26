using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.DomainService
{
    public interface ITransactionRepository
    {
        Transaction CreateTransaction(Transaction transaction);
        Transaction RemoveTransaction(Transaction transaction);
        Transaction AddTransactionToAccount(Account account, Transaction transaction);
        Transaction RemoveTransactionFromAccount(Account account, Transaction transaction);
        IEnumerable<Transaction> GetAllTransactions();
    }
}
