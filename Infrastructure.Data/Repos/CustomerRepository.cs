using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
namespace Infrastructure.Data.Repos
{
    class CustomerRepository : ICustomerRepository
    {
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
