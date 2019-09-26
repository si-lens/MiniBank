using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    public interface ITransactionService
    {
        ITransaction CreateTransaction(ITransaction transaction);
        ITransaction RemoveTransaction(ITransaction customer);
        ITransaction AddTransactionToAccount(IAccountBank account,ITransaction transaction);
        ITransaction RemoveTransactionFromAccount(IAccountBank account, ITransaction transaction);
        List<ITransaction> GetAllTransactions();
    }
}
