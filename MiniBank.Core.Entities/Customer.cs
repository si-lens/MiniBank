using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
   public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        //public List<Account> Accounts { get; set; }
        public ICollection<CustomersAccounts> customersAccounts { get; set; }
        public Customer()
        {
        }
        public Customer(Account _account)
        {
            CustomersAccounts cs = new CustomersAccounts()
            {
                account = _account,
                accountNumber = _account.AccountNumber

            };
            customersAccounts = new List<CustomersAccounts>();
            customersAccounts.Add(cs);
        }

    }
}
