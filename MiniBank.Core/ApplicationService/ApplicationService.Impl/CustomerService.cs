using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService.ApplicationService.Impl
{
    class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepo;

        public CustomerService(ICustomerRepository customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        public void AddBankAccountToCustomer(IAccountBank account)
        {
            throw new NotImplementedException();
        }

        public Customer CreateCustomer()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerWithID(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveBankAccountFromCustomer(IAccountBank account)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
