using System.Collections.Generic;

namespace fruit_shop
{
    class CartItems
    {
        private List<CartItem> items = new List<CartItem>();
        public void Add(CartItem item)
        {
            items.Add(item);
        }
        public int Length { get => items.Count; }
        public CartItem this[int i] //indexer
        {
            get => items[i];
            set => items[i] = value;
        }
    }
}