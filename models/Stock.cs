using System.Collections.Generic;

namespace fruit_shop
{
    static class Stock
    {
        private static List<Fruit> fruits = new List<Fruit>();

        // CRUD DB Operations
        public static void AddFruit(Fruit fruit)
        {
            fruits.Add(fruit);
            // return this; //fluent builder // this keyword is not valid on a static property
        }
        public static void UpdateFruit()
        {
            // change fruit price, availability
        }
        public static void DeleteFruit()
        {
            // delete from stock
        }
        public static List<Fruit> GetAllFruits() //return all clones
        {
            List<Fruit> ret = new List<Fruit>();
            foreach(var i in fruits)
                ret.Add(i.Clone(i));
            return ret;
        }
        public static Fruit GetFruitByID(int ID) //returns a clone
        {
            Fruit fruit = null;
            foreach(var f in fruits)
            {
                if(f.Product_ID == ID)
                {
                    fruit = f.Clone(f);
                    break;
                }
            }
            return fruit;
        }
    }
}