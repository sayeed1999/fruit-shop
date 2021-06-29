using System;
using System.Collections.Generic;

namespace fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger console = new ConsoleLogger();
            
            StoreInformation storeInfo = new StoreInformation(new FileLogger());


            // var banana = new Fruit(); can't access private member
            var banana = Fruit.NewFruit()
                .HasName("Banana")
                .HasCategoryBySeason(Category.Whole_year)
                .HasPricePerKG(50)
                .HasIsInStock(true);

            var jackfruit = Fruit.NewFruit()
                .HasCategoryBySeason(Category.Summer)
                .HasIsInStock(true)
                .HasName("Jackfruit")
                .HasPricePerKG(100);
            
            var mango = Fruit.NewFruit()
                .HasCategoryBySeason(Category.Summer)
                .HasIsInStock(false)
                .HasName("Mango")
                .HasPricePerKG(55);
            
            var pineapple = Fruit.NewFruit()
                .HasCategoryBySeason(Category.Winter)
                .HasIsInStock(false)
                .HasName("Pineapple")
                .HasPricePerKG(40);
            
            Stock.AddFruit(jackfruit); Stock.AddFruit(banana); Stock.AddFruit(mango); Stock.AddFruit(pineapple);

            List<Fruit> fruits = Stock.GetAllFruits(); //getting a copy...
            fruits[0].HasName("lala"); // the fruits in stock shouldnt get modified, all should be a copy
            foreach(var i in fruits) storeInfo.Store(i.ToString());
            storeInfo.Store(); //newLine

            // fetching fruits data again...  to check lala isnt modified on the real DB!
            List<Fruit> fruits2 = Stock.GetAllFruits();
            storeInfo.Store("When i again fetch, i see fruit name lala was applied on a copied version, original remains okay..");
            foreach(var i in fruits2) storeInfo.Store(i.ToString());
            storeInfo.Store(); //newLine

            var filter = new Filter();
            var all_fruits = Stock.GetAllFruits();

            storeInfo.Store("The summer fruits available:-");
            List<Fruit> summer_fruits = filter.FilterBy(all_fruits, new SeasonSpecification(Category.Summer));
            foreach(var i in summer_fruits) storeInfo.Store(i.ToString());
            storeInfo.Store();

            storeInfo.Store("The winter fruits available:-");
            List<Fruit> winter_fruits = filter.FilterBy(all_fruits, new SeasonSpecification(Category.Winter));
            foreach(var i in winter_fruits) storeInfo.Store(i.ToString());
            storeInfo.Store();

            storeInfo.Store("The fruits (in stock):-");
            List<Fruit> in_stock = filter.FilterBy(all_fruits, new AvailabilitySpecification(true));
            foreach(var i in in_stock) storeInfo.Store(i.ToString());
            storeInfo.Store();

            storeInfo.Store("The fruits (out of stock):-");
            List<Fruit> out_of_stock = filter.FilterBy(all_fruits, new AvailabilitySpecification(false));
            foreach(var i in out_of_stock) storeInfo.Store(i.ToString());
            storeInfo.Store();





            storeInfo.Store("Searh all fruits whose name contains 'an':-");
            List<Fruit> search = filter.FilterBy(all_fruits, new SearchSpecification("an"));
            foreach(var i in search) storeInfo.Store(i.ToString());
            storeInfo.Store();




            var cart = new Cart();
            cart.AddToCart(banana.Product_ID, 0.5);
            cart.AddToCart(banana.Product_ID, 0.1);
            cart.AddToCart(mango.Product_ID, 5.00);

            CartItems shopping_cart = cart.GetCart();
            storeInfo.Store("Items on Cart:-");
            for(int i=0; i<shopping_cart.Length; ++i)
            {
                string str = $"{shopping_cart[i].Item.Name} -> {shopping_cart[i].QtyInKG}";
                console.Log(str);
                storeInfo.Store(str);
            }
            storeInfo.Store();
        }
    }
}
