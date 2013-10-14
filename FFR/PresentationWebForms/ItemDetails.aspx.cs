using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using PresentationWebForms.Models;

namespace PresentationWebForms
{
    public partial class ItemDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Item> GetSingleItem([QueryString("ItemId")]int? ItemId)
        {
            var _db = new PresentationWebForms.Models.DataContext();
            IQueryable<Item> query = _db.Items;
            if (ItemId.HasValue && ItemId > 0)
            {
                query = query.Where(p => p.ItemId == ItemId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}