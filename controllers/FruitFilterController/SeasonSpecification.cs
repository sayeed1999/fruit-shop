
namespace fruit_shop
{
    class SeasonSpecification : ISpecification
    {
        private Category _category;
        public SeasonSpecification(Category c)
        {
            _category = c;
        }
        public bool isSatisfied(Fruit f)
        {
            return f.CategoryBySeason == _category;
        }
    }
}