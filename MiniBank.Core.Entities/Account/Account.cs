using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
   public class Account
    {
        int AccountNumber { get; set; }
        double InterestRate { get; set; }
        double Balance { get; set; }
        List<Transaction> Transactions { get; set; }

        List<Customer> Customers { get; }

        public Account(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Account creation customer argument is null");
            Customers = new List<Customer>();
            Customers.Add(customer);
        }
        
    }
}
