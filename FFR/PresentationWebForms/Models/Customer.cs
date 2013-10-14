using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.SalesHeaders = new HashSet<SalesHeader>();
            this.WebUserTables = new HashSet<WebUserTable>();
        }
        [Required]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Suite { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }

        public virtual ICollection<SalesHeader> SalesHeaders { get; set; }
        public virtual ICollection<WebUserTable> WebUserTables { get; set; }
    }
}