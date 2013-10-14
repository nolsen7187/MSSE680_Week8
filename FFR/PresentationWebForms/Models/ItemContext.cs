using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=FFREntities")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items {get; set;}
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<SalesHeader> SalesHeaders { get; set; }
        public DbSet<SalesItem> SalesItems { get; set; }
        public DbSet<WebUserTable> WebUsers { get; set; }

    }
}