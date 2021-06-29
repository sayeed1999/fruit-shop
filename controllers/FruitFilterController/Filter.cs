using System.Collections.Generic;

namespace fruit_shop
{
    class Filter // SPECIFICATION PATTERN !!!
    {
        public List<Fruit> FilterBy(List<Fruit> fruits, ISpecification spec)
        {
            List<Fruit> ret = new List<Fruit>();
            foreach(var f in fruits)
            {
                if(spec.isSatisfied(f) == true)
                    ret.Add(f.Clone(f));
            }
            return ret;
        }
    }
}