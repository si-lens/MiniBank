using Microsoft.EntityFrameworkCore;
using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Repos
{
    class CustomerRepository : ICustomerRepository
    {
        private MiniBankContext context;

        public CustomerRepository(MiniBankContext ctx)
        {
            context = ctx;
        }
        public Customer AddBankAccountToCustomer(Account account, Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return context.customers.AsNoTracking().ToList();
        }

        public Customer GetCustomerWithID(int id)
        {
            throw new NotImplementedException();
        }

        public Customer RemoveBankAccountFromCustomer(Account account, Customer customer)
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
