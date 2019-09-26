using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
namespace Infrastructure.Data.Repos
{
    class CustomerRepository : ICustomerRepository
    {
        public Customer AddBankAccountToCustomer(IAccountBank account, Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerWithID(int id)
        {
            throw new NotImplementedException();
        }

        public Customer RemoveBankAccountFromCustomer(IAccountBank account, Customer customer)
        { 
            throw new NotImplementedException();
        }

        public Customer RemoveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
        public Customer UpdateCustomer(Customer customer)
        {
            return null;
        }
    }
}
