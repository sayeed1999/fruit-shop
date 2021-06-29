
namespace fruit_shop
{
    class CartItem
    {
        public Fruit Item;
        public double QtyInKG;
        public CartItem(Fruit fruit, double qty)
        {
            Item = fruit;
            QtyInKG = qty;
        }
    }
}