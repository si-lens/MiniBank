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

        public IAccountBank AddCustomerToBankAccount(IAccountBank account, Customer customer)
        {
            return accountRepo.AddCustomerToBankAccount(account, customer);
        }



        public IAccountBank CreateAccount(Customer customer)
        {
            return accountRepo.CreateAccount(customer);
        }

        public IAccountBank GetAccountWithID(int id)
        {
            return accountRepo.GetAccountWithID(id);
        }






        IEnumerable<IAccountBank> IAccountService.GetAllAccounts()
        {
            return accountRepo.GetAllAccounts();
        }

        IAccountBank IAccountService.RemoveAccount(IAccountBank accountToRemove)
        {
            return accountRepo.RemoveAccount(accountToRemove);
        }

        IAccountBank IAccountService.RemoveOwnerFromBankAccount(IAccountBank account, Customer owner)
        {
            throw new NotImplementedException();
        }
    }
}
