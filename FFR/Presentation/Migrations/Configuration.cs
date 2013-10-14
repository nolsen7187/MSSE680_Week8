namespace Presentation.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Presentation.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Presentation.DAL.DALContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Presentation.DAL.DALContext context)
        {
            var customers = new List<Customer>
            {
                new Customer {FirstName = "Presentation", LastName = "Olsen", City = "Presentation", State = "CO", Zip = "80123", Email = "nolsen@regis.edu", Phone = "3031234567"}
            };
            customers.ForEach(c => context.Customers.AddOrUpdate(p => p.CustomerId, c));
            context.SaveChanges();
        }
    }
}
