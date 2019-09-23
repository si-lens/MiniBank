using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    public interface IAccountService
    { // Add, GetById, GetAll, Update, Remove

        IAccountBank CreateAccount(Customer owner, double initialBalance = 0.0, double initialInterestRate = 0.0);
        void RemoveAccount(IAccountBank account);
        void AddOwnerToBankAccount(IAccountBank account, Customer owner);
        void RemoveOwnerFromBankAccount(IAccountBank account, Customer owner);
        List<IAccountBank> GetAllAccounts();
        IAccountBank GetAccountWithID(int id);


    }
}
