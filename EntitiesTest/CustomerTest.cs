
using MiniBank.Core.Entities;
using NUnit.Framework;
using System;

namespace MiniBank.Tests.UnitTests
{
    [TestFixture]
    public class CustomerTest
    {
        int Id = 42;
        string FirstName = "Marek";
        string LastName = "Soczewka";
        DateTime BirthDate = System.DateTime.Now;
        string Email = "szymon@stancik.jan";
        string PhoneNumber = "+45 66642069";
        string Address = "1st of Julius Ceaser street, Warsaw";

        [Test]
        public void CreateCustomerTestId()
        {
            Customer customer = new Customer(Id, FirstName, LastName, BirthDate, Email, PhoneNumber, Address);
            Assert.AreEqual(Id, customer.Id);
        }

        public void CreateCustomerTestFirstName()
        {
            Customer customer = new Customer(Id, FirstName, LastName, BirthDate, Email, PhoneNumber, Address);
            Assert.AreEqual(FirstName, customer.FirstName);
        }

        public void CreateCustomerTestLastName()
        {
            Customer customer = new Customer(Id, FirstName, LastName, BirthDate, Email, PhoneNumber, Address);
            Assert.AreEqual(LastName, customer.LastName);
        }

        public void CreateCustomerTestBirthDate()
        {
            Customer customer = new Customer(Id, FirstName, LastName, BirthDate, Email, PhoneNumber, Address);
            Assert.AreEqual(BirthDate, customer.BirthDate);
        }

        public void CreateCustomerTestEmail()
        {
            Customer customer = new Customer(Id, FirstName, LastName, BirthDate, Email, PhoneNumber, Address);
            Assert.AreEqual(Email, customer.Email);
        }

        public void CreateCustomerTestPhoneNumber()
        {
            Customer customer = new Customer(Id, FirstName, LastName, BirthDate, Email, PhoneNumber, Address);
            Assert.AreEqual(PhoneNumber, customer.PhoneNumber);
        }

        public void CreateCustomerTestAddress()
        {
            Customer customer = new Customer(Id, FirstName, LastName, BirthDate, Email, PhoneNumber, Address);
            Assert.AreEqual(Address, customer.Address);
        }
    }
}