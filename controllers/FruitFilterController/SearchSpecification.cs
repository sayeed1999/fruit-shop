
namespace fruit_shop
{
    class SearchSpecification : ISpecification
    {
        private string _searchTerm;
        public SearchSpecification(string term)
        {
            _searchTerm = term;
        }
        public bool isSatisfied(Fruit f)
        {
            string _name = f.Name.ToLower();
            return _name.Contains( _searchTerm.ToLower() );
        }
    }
}