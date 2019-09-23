using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    public  interface ICustomerService
    {
        Customer CreateCustomer();
        void RemoveCustomer(Customer customer);
        void AddBankAccountToCustomer(IAccountBank account);
        void RemoveBankAccountFromCustomer(IAccountBank account);
        List<Customer> GetAllCustomers();
        Customer GetCustomerWithID(int id);
        
    }
}
