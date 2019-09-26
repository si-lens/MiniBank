using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
    class Withdrawal : ITransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}
