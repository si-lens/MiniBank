using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
   public class Account
    {
        public const double DEFAULT_INTEREST_RATE = 0.01;
        public const double LOW_INTEREST_RATE = 0.00;
        public const double HIGT_INTEREST_RATE = 0.10;

        public int AccountNumber { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
         public List<Transaction> Transactions { get; set; }
        public ICollection<CustomersAccounts> customersAccounts { get; set; }

        //public List<Customer> Customers { get; }

        public Account(int accountNumber, double balance, double interestRate = DEFAULT_INTEREST_RATE)
        {
            AccountNumber = accountNumber;
            InterestRate = interestRate;
            Balance = balance;
            var newCus = new Customer(this);
            CustomersAccounts cs = new CustomersAccounts()
            {
                customer = newCus,
                customerID = newCus.Id
            };
            customersAccounts = new List<CustomersAccounts>();
            customersAccounts.Add(cs);
        }
        
    }
}
