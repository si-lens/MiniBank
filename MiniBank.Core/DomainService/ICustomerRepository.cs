using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.DomainService
{
    public interface ICustomerRepository
    {
        Customer CreateCustomer(Customer customer);
        Customer RemoveCustomer(Customer customer);
        Customer AddBankAccountToCustomer(Account account, Customer customer);
        Customer RemoveBankAccountFromCustomer(Account account, Customer customer);
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerWithID(int id);

        Customer UpdateCustomer(Customer customer);
    }
}
