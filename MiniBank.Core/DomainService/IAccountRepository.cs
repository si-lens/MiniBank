using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.DomainService
{ 
    public interface IAccountRepository 
{
    Account CreateAccount(Customer customer);
    Account RemoveAccount(Account account);
    Account AddCustomerToBankAccount(Account account, Customer customer);
    Account RemoveCustomerFromBankAccount(Account account, Customer customer);
    IEnumerable<Account> GetAllAccounts();
    Account GetAccountWithID(int id);
}
}
