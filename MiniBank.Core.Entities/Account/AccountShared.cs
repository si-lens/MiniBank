using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
    class AccountShared : IAccountBank
    {
        public AccountShared()
        {

        }
        public int AccountNumber { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public List<ITransaction> Transactions { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
