using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Repos
{
    class AccountRepository : IAccountRepository
    {
        public Account AddCustomerToBankAccount(Account account, Customer customer)
        {
            throw new NotImplementedException();
        }

        public Account CreateAccount(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountWithID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public Account RemoveAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Account RemoveCustomerFromBankAccount(Account account, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
