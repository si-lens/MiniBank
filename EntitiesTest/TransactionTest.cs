
using NUnit.Framework;
using Infrastructure.Data.Repos;
using System;
using MiniBank.Core.Entities;

namespace MiniBank.Tests.UnitTests
{
    [TestFixture]
    public class TransactionTest
    {
        int Id = 5;
        DateTime Date = System.DateTime.Now;
        double Amount = 666.42;


        [Test]
        public void CreateTransactionTestId()
        {
            Transaction trans = new Transaction(Id, Date,  Amount, Transaction.TransactionType.Deposit);
            Assert.AreEqual(Id, trans.Id);
        }
        public void CreateTransactionTestDate()
        {
            Transaction trans = new Transaction(Id, Date,  Amount, Transaction.TransactionType.Deposit);
            Assert.AreEqual(Date, trans.Date);
        }

        public void CreateTransactionTestAmount()
        {
            Transaction trans = new Transaction(Id, Date, Amount, Transaction.TransactionType.Deposit);
            Assert.AreEqual(Amount, trans.Amount);
        }

        public void CreateTransactionTestTransactionType()
        {
            Transaction trans = new Transaction(Id, Date, Amount, Transaction.TransactionType.Deposit);
            Assert.AreEqual(Transaction.TransactionType.Deposit, trans.transactionType);
        }
        /* [Theory]
         [InlineData(0, 500, 500)]
         public void Add_Deposit(double initial, double x, double expected)
         {
             IAccount Acc = new AccountClassic();
             Acc.Balance = initial;
             Acc.AccountNumber = "Test0123";
             Acc.InterestRate = 0;
             Acc.Transactions = null;
             ITransaction trans = new Deposit();
             trans.Description = "Test";
             trans.Id = int.MaxValue;
             trans.Date = System.DateTime.Now;
             trans.Amount = x;
             IAccountRepository TestRepo = new AccountRepository();
             Acc = TestRepo.AddTransactionToAccount(Acc, trans);
             Assert.Equal(expected, Acc.Balance);
         }*/

        /*[Theory]
        [InlineData(0, 500, 500)]
        public void Make_Withdraw(double initial, double x, double expected)
        {
            IAccount Acc = new AccountClassic();
            Assert.Equal(expected, Acc.Balance);
        }*/

    }
}