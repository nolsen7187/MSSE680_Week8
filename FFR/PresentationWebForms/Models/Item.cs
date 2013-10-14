using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class Item
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
        public Nullable<int> ItemCategoryId { get; set; }

        public virtual ICollection<SalesItem> SalesItems { get; set; }
        public virtual ItemCategory ItemCategory { get; set; }
    
        
    }
}