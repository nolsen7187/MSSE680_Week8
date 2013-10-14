using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace PresentationWebForms
{
    public partial class ItemList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Item> GetItems([QueryString("id")] int? itemCategoryId)
        {
            var _db = new FFREntities();//PresentationWebForms.Models.DataContext();
            IQueryable<Item> query = _db.Items;
            if (itemCategoryId.HasValue && itemCategoryId > 0)
            {
                query = query.Where(p => p.ItemCategoryId == itemCategoryId);
            }
            return query;
        }
    }
}