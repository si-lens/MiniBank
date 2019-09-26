using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entities
{
   public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<Account> Accounts { get; set; }    
        
        private Customer(Account account)
        {
            if (account == null)
                throw new ArgumentNullException("Customer.Create : Account can't be null");
            Accounts = new List<Account>();
            Accounts.Add(account);
        }

       /* public Customer(int id,string firstname, string lastname, DateTime birthdate, string email,string phonenumber,string address)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Email = email;
            PhoneNumber = phonenumber;
            Address = address;
            Accounts = new List<IAccountBank>();
        }*/

    }
}
