using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasuryExpress.Shared;

namespace TreasuryExpress.Server.DbConf
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balance>().HasKey(ba => new { ba.AccountNumber, ba.BalanceDate});
        }



        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Balance> Balances { get; set; }

        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Log> Logs { get; set; }

    }
}
