using MiniBank.Core.DomainService;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniBank.Core.ApplicationService.ApplicationService.Impl
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepo;

        public CustomerService(ICustomerRepository customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        public Customer AddBankAccountToCustomer(IAccountBank account, Customer customer)
        {
            return customerRepo.AddBankAccountToCustomer(account, customer);
        }

        public Customer CreateCustomer(Customer customer)
        {
            return customerRepo.CreateCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerRepo.GetAllCustomers().ToList();
        }

        public Customer GetCustomerWithID(int id)
        {
            return customerRepo.GetCustomerWithID(id);
        }
        public Customer RemoveBankAccountFromCustomer(IAccountBank account, Customer customer)
        {
            return customerRepo.RemoveBankAccountFromCustomer(account, customer);
        }

        public Customer Delete(Customer customer)
        {
            return customerRepo.RemoveCustomer(customer);
        }

        public Customer Update(Customer customer)
        {
            return customerRepo.UpdateCustomer(customer); 
        }
    }
}
