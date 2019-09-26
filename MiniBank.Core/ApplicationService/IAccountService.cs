using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    public interface IAccountService
    { // Add, GetById, GetAll, Update, Remove

        Account CreateAccount(Customer customer);
        Account RemoveAccount(Account accountToRemove);
        Account AddCustomerToBankAccount(Account account, Customer customer);
        Account RemoveOwnerFromBankAccount(Account account, Customer customer);
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountWithID(int id);


    }
}
