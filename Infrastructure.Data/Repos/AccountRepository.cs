using Microsoft.EntityFrameworkCore;
using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Repos
{
    class AccountRepository : IAccountRepository
    {
        private MiniBankContext context;

        public AccountRepository(MiniBankContext ctx)
        {
            context = ctx;
        }
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
            return context.accounts.AsNoTracking().ToList();
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
