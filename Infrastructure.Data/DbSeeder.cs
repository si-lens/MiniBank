using Microsoft.EntityFrameworkCore;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class DbSeeder
    {
        public const int min = 1_000_000;
        public const int max = 9_999_999;
        public static HashSet<int> numbers = new HashSet<int>();
        public static Random random = new Random();
  
        public static void Seed(MiniBankContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();


            //1
            Account account = new Account(AccNumberGenerator(), random.Next(1_000_000));
            List<CustomersAccounts> csList = account.customersAccounts.ToList();
            Customer cust = csList[0].customer;
            cust.FirstName = "Jack";
            cust.LastName = "Goyer";
            cust.BirthDate = new DateTime(1979, 11, 11);
            cust.Address = "Grovestreet 123";
            cust.PhoneNumber = "12345678";
            var tracker1 = ctx.ChangeTracker.Entries<CustomersAccounts>();
            ctx.Attach(account).State = EntityState.Added;

            //2
            Account account2 = new Account(AccNumberGenerator(), random.Next(1_000_000));
            List<CustomersAccounts> csList2 = account.customersAccounts.ToList();
            Customer cust2 = csList[0].customer;
            cust2.FirstName = "Rocky";
            cust2.LastName = "Balboa";
            cust2.BirthDate = new DateTime(1959, 1, 15);
            cust2.Address = "Hoolywood 79";
            cust2.PhoneNumber = "87654321";
            ctx.Attach(account2).State = EntityState.Added;

            //3
            Account account3 = new Account(AccNumberGenerator(), random.Next(1_000_000));
            List<CustomersAccounts> csList3 = account.customersAccounts.ToList();
            Customer cust3 = csList[0].customer;
            cust3.FirstName = "Serena";
            cust3.LastName = "Wiliams";
            cust3.BirthDate = new DateTime(1981, 5, 1);
            cust3.Address = "New York 179";
            cust3.PhoneNumber = "12367845";
            ctx.Attach(account3).State = EntityState.Added;

            //4
            Account account4 = new Account(AccNumberGenerator(), random.Next(1_000_000));
            List<CustomersAccounts> csList4 = account.customersAccounts.ToList();
            Customer cust4 = csList[0].customer;
            cust4.FirstName = "Tara";
            cust4.LastName = "Red";
            cust4.BirthDate = new DateTime(1977, 11, 25);
            cust4.Address = "Somestreet 12";
            cust4.PhoneNumber = "87643241";
            ctx.Attach(account4).State = EntityState.Added;

            //5
            Account account5 = new Account(AccNumberGenerator(), random.Next(1_000_000));
            List<CustomersAccounts> csList5 = account.customersAccounts.ToList();
            Customer cust5 = csList[0].customer;
            cust5.FirstName = "Pamela";
            cust5.LastName = "Yates";
            cust5.BirthDate = new DateTime(1939, 6, 5);
            cust5.Address = "Somestreet 9";
            cust5.PhoneNumber = "87662902";
            ctx.Attach(account5).State = EntityState.Added;


            ctx.SaveChanges();








        }
        public static int AccNumberGenerator()
        {
            
            var num = random.Next();
            bool finished = false;
            while (!finished)
            {
                num = random.Next(min, max);
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                    finished = true;
                }
            }

            return num;
        }
    }
}
