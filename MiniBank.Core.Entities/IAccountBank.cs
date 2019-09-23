using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
   public interface IAccountBank
    {
        string AccountNumber { get; set; }
        double InterestRate { get; set; }
        double Balance { get; set; }
        List<ITransaction> Transactions { get; set; }

        List<Customer> Customers { get; }

        
    }
}
