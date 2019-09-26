using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    public interface IAccountService
    { // Add, GetById, GetAll, Update, Remove

        IAccountBank CreateAccount(Customer customer);
        IAccountBank RemoveAccount(IAccountBank accountToRemove);
        IAccountBank AddCustomerToBankAccount(IAccountBank account, Customer customer);
        IAccountBank RemoveOwnerFromBankAccount(IAccountBank account, Customer customer);
        IEnumerable<IAccountBank> GetAllAccounts();
        IAccountBank GetAccountWithID(int id);


    }
}
