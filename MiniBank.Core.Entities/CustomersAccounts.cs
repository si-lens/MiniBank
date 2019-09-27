using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
    public class CustomersAccounts
    {
        public int accountNumber { get; set; }
        public Account account { get; set; }
        public int customerID { get; set; }

        public Customer customer { get; set; }

    }
}
