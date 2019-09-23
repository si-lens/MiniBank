using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    interface ITransactionService
    {
        ITransaction CreateTransaction();
        void RemoveTransaction(ITransaction customer);
        void AddTransactionToAccount(IAccountBank account,ITransaction transaction);
        void RemoveTransactionFromAccount(IAccountBank account, ITransaction transaction);
        List<ITransaction> GetAllTransactions();
    }
}
