using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    public interface ITransactionService
    {
        Transaction CreateTransaction(Transaction transaction);
        Transaction RemoveTransaction(Transaction customer);
        Transaction AddTransactionToAccount(Account account,Transaction transaction);
        Transaction RemoveTransactionFromAccount(Account account, Transaction transaction);
        List<Transaction> GetAllTransactions();
    }
}
