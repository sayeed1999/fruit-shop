using System.Collections.Generic;

namespace fruit_shop
{
    class Cart
    {
        Dictionary<int, double> cart = new Dictionary<int, double>();
        public void AddToCart(int productID, double qtyInKG)
        {
            if(cart.ContainsKey(productID))
                cart[productID] += qtyInKG;
            else cart[productID] = qtyInKG;
        }
        public void RemoveFromCart(int productID)
        {
            cart.Remove(productID);
        }
        public void UpdateCart(int productID, double qtyInKG)
        {
            cart[productID] = qtyInKG;
        }
        public void ClearCart()
        {
            cart.Clear();
        }
        public CartItems GetCart()
        {
            var ret = new CartItems();
            foreach(var item in cart)
            {
                var f = Stock.GetFruitByID(item.Key);
                var cartItem = new CartItem(f, item.Value);
                ret.Add(cartItem);
            }
            return ret;
        }
    }
}