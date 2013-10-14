using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DAL;

namespace Presentation.Models
{
    public partial class Item
    {
        public Item()
        {
            this.SalesItems = new HashSet<SalesItem>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> QuantityAvailable { get; set; }
        public Nullable<decimal> ItemCost { get; set; }
        public Nullable<decimal> Price { get; set; }

        public virtual ICollection<SalesItem> SalesItems { get; set; }
    }
}