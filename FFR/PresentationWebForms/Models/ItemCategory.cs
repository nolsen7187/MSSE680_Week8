using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class ItemCategory
    {
        public ItemCategory()
        {
            this.Items = new HashSet<Item>();
        }

        public int ItemCategoryId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}