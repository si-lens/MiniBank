using MiniBank.Core.Entities;
using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService
{
    public  interface ICustomerService
    {
        Customer CreateCustomer(Customer customer);
        Customer Delete(Customer customer);
        Customer AddBankAccountToCustomer(IAccountBank account , Customer customer);
        Customer RemoveBankAccountFromCustomer(IAccountBank account, Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetCustomerWithID(int id);
        Customer Update(Customer customer);
    }
}
