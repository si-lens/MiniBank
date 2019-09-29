
using MiniBank.Core.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Tests.UnitTests
{
    [TestFixture]
    public class AccountTest
    {

        int AccountNumber = 1000;
        double InterestRate = 0.5;
        double Balance = 250;
        List<Transaction> Transactions = new List<Transaction>();
        List<Customer> Customers = new List<Customer>();

        [Test]
        public void CreateAccountTestAccountNumber()
        {
            Account account = new Account(AccountNumber, Balance);
            Assert.AreEqual(AccountNumber, account.AccountNumber);
        }
     
        public void CreateAccountTestBalance()
        {
            Account account = new Account(AccountNumber, Balance);
            Assert.AreEqual(Balance, account.Balance);
        }
 
    }
}