
namespace fruit_shop
{
    class AvailabilitySpecification : ISpecification
    {
        private bool _isInStock;
        public AvailabilitySpecification(bool inStock)
        {
            _isInStock = inStock;
        }
        public bool isSatisfied(Fruit f)
        {
            return f.IsInStock == _isInStock;
        }
    }
}