using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Repos
{
    class AccountRepository : IAccountRepository
    {
        public void AddOwnerToBankAccount(IAccountBank account, Customer owner)
        {
            throw new NotImplementedException();
        }

        public IAccountBank CreateAccount(Customer owner, double initialBalance = 0, double initialInterestRate = 0)
        {
            throw new NotImplementedException();
        }

        public IAccountBank GetAccountWithID(int id)
        {
            throw new NotImplementedException();
        }

        public List<IAccountBank> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public void RemoveAccount(IAccountBank account)
        {
            throw new NotImplementedException();
        }

        public void RemoveOwnerFromBankAccount(IAccountBank account, Customer owner)
        {
            throw new NotImplementedException();
        }
    }
}
