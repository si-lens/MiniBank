using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService.ApplicationService.Impl
{
    public class CustomerService : ICustomerService
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

        public Customer CreateCustomer(Customer customer)
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

        public Customer Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
