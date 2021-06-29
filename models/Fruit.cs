
namespace fruit_shop
{
    class Fruit
    {
        private static int Unique_Product_ID = 0;
        public int Product_ID { get; private set; }
        public string Name { get; private set; }
        public Category CategoryBySeason { get; private set; }
        public double PricePerKG { get; private set; }
        public bool IsInStock { get; private set; }
        
        // constructors (BUILDER PATTERN)
        private Fruit() {}
        public static Fruit NewFruit() // Factory Method/Function
        {
            Unique_Product_ID++;
            var fruit = new Fruit();
            fruit.Product_ID = Unique_Product_ID;
            return fruit;
        }
        public Fruit HasName(string name)
        {
            Name = name;
            return this;
        }
        public Fruit HasCategoryBySeason(Category category)
        {
            CategoryBySeason = category;
            return this;
        }
        public Fruit HasPricePerKG(double price)
        {
            PricePerKG = price;
            return this;
        }
        public Fruit HasIsInStock(bool inStock)
        {
            IsInStock = inStock;
            return this;
        }

        // overriding base class!
        public override string ToString()
        {
            return $"Product_ID: {Product_ID}, Name: {Name}, CategoryBySeason: {CategoryBySeason}, PricePerKG: {PricePerKG}, IsInStock: {IsInStock}.";
        }
        // memberwise clone! (PROTOTYPE PATTERN)
        public Fruit Clone(Fruit obj)
        {
            return (Fruit)this.MemberwiseClone();
        }
    }
}