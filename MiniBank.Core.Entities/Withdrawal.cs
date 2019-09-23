using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
    class Withdrawal : ITransaction
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
