using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
    class AccountStudent : IAccountBank
    {
        public string AccountNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double InterestRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITransaction> Transactions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Customer> Customers => throw new NotImplementedException();
    }
}
