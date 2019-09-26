using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    public  interface ICustomerService
    {
        Customer CreateCustomer(Customer customer);
        Customer Delete(int id);
        void AddBankAccountToCustomer(IAccountBank account);
        void RemoveBankAccountFromCustomer(IAccountBank account);
        List<Customer> GetAllCustomers();
        Customer GetCustomerWithID(int id);
        Customer Update(Customer customer);
    }
}
