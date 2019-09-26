using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService.ApplicationService.Impl
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepo;

        public AccountService(IAccountRepository accountRepo)
        {
            this.accountRepo = accountRepo;
        }

        public Account AddCustomerToBankAccount(Account account, Customer customer)
        {
            return accountRepo.AddCustomerToBankAccount(account, customer);
        }



        public Account CreateAccount(Customer customer)
        {
            return accountRepo.CreateAccount(customer);
        }

        public Account GetAccountWithID(int id)
        {
            return accountRepo.GetAccountWithID(id);
        }






        IEnumerable<Account> IAccountService.GetAllAccounts()
        {
            return accountRepo.GetAllAccounts();
        }

        Account IAccountService.RemoveAccount(Account accountToRemove)
        {
            return accountRepo.RemoveAccount(accountToRemove);
        }

        Account IAccountService.RemoveOwnerFromBankAccount(Account account, Customer owner)
        {
            throw new NotImplementedException();
        }
    }
}
