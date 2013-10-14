using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Presentation.Models;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

namespace Presentation.DAL
{

    public class DALContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalesHeader> SalesHeaders { get; set; }
        public DbSet<SalesItem> SalesItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    
}