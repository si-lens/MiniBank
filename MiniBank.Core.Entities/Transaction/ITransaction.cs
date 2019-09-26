using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
    public interface ITransaction
    {
        int Id { get; set; }
        DateTime Date {get; set;}

        string Description { get; set; }

        double Amount { get; set; }
    }
}
