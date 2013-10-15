using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using PresentationWebForms;

namespace PresentationWebForms.Logic
{
    public class ShoppingCartActions
    {
        public int ShoppingSalesId { get; set; }

        private FFREntities _db = new FFREntities();

        public const string SalesIdSessionKey = "SalesId";

        public void AddToCart(int id)
        {
            // Retrieve the product from the database.           
            ShoppingSalesId = GetSalesId();

            var shoppingCartItem = _db.SalesItems.SingleOrDefault(
                c => c.SalesId == ShoppingSalesId
                && c.ItemId == id);
            if (shoppingCartItem == null)
            {
                // Create a new cart item if no cart item exists.                 
                shoppingCartItem = new SalesItem
                {
                    //SalesItemTransId = Guid.NewGuid().ToString(),
                    ItemId = id,
                    SalesId = ShoppingSalesId,
                    ItemName = _db.Items.SingleOrDefault(
                     p => p.ItemId == id).ItemName,
                    Price = _db.Items.SingleOrDefault(
                     p => p.ItemId == id).Price,
                    Qty = 1,
                    LineAmount = _db.Items.SingleOrDefault(
                     p => p.ItemId == id).Price * 1,
                };

                _db.SalesItems.Add(shoppingCartItem);
            }
            else
            {
                // If the item does exist in the cart,                  
                // then add one to the quantity.                 
                shoppingCartItem.Qty++;
            }
            _db.SaveChanges();
        }

        public int GetSalesId()
        {
            if (HttpContext.Current.Session[SalesIdSessionKey] == null)
            {
                /*if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[SalesIdSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[SalesIdSessionKey] = tempCartId.ToString();
                }*/
                HttpContext.Current.Session[SalesIdSessionKey] = 1001;
            }
            return Convert.ToInt16(HttpContext.Current.Session[SalesIdSessionKey]);
        }

        public List<SalesItem> GetSalesCartItems()
        {
            ShoppingSalesId = GetSalesId();

            return _db.SalesItems.Where(
                c => c.SalesId == ShoppingSalesId).ToList();
        }
    }
}