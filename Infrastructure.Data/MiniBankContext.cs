using Microsoft.EntityFrameworkCore;
using MiniBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    class MiniBankContext : DbContext
    {
        public MiniBankContext(DbContextOptions<MiniBankContext> opt) : base(opt)
        {

        }


        public DbSet<Customer> customers { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Transaction> transactions { get; set; }
    }
}
