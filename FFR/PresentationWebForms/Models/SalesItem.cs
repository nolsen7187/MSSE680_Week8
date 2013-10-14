using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class SalesItem
    {
        public int SalesItemTransId { get; set; }
        public int SalesId { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> LineAmount { get; set; }
        public string ItemName { get; set; }

        public virtual Item Item { get; set; }
        public virtual SalesHeader SalesHeader { get; set; }
    }
}