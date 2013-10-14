using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DAL;

namespace Presentation.Models
{
    public partial class SalesHeader
    {
        public SalesHeader()
        {
            this.SalesItems = new HashSet<SalesItem>();
        }

        public int SalesId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<decimal> OrderSalesBalance { get; set; }
        public Nullable<decimal> OrderTaxAmount { get; set; }
        public Nullable<decimal> OrderTotal { get; set; }
        public string SalesStatus { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<SalesItem> SalesItems { get; set; }
    }
}