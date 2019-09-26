using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.DomainService
{ 
    public interface IAccountRepository 
{
    IAccountBank CreateAccount(Customer customer);
    IAccountBank RemoveAccount(IAccountBank account);
    IAccountBank AddCustomerToBankAccount(IAccountBank account, Customer customer);
    IAccountBank RemoveCustomerFromBankAccount(IAccountBank account, Customer customer);
    IEnumerable<IAccountBank> GetAllAccounts();
    IAccountBank GetAccountWithID(int id);
}
}
