using Microsoft.EntityFrameworkCore;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class MiniBankContext : DbContext
    {
        public MiniBankContext(DbContextOptions<MiniBankContext> opt) : base(opt)
        {

        }


        public DbSet<Customer> customers { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Transaction> transactions { get; set; }

        public DbSet<CustomersAccounts> customersAccounts { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(a => a.Transactions);

            modelBuilder.Entity<Account>()
                .HasKey(cs => cs.AccountNumber);



            modelBuilder.Entity<CustomersAccounts>()
            .HasKey(cs => new { cs.customerID, cs.accountNumber });

            modelBuilder.Entity<CustomersAccounts>()
                .HasOne(cs => cs.account)
                .WithMany(a => a.customersAccounts)
                .HasForeignKey(cs => cs.accountNumber);

            modelBuilder.Entity<CustomersAccounts>()
                .HasOne(cs => cs.customer)
                .WithMany(c => c.customersAccounts)
                .HasForeignKey(cs => cs.customerID);
        }



    }




    }
    


  



    
