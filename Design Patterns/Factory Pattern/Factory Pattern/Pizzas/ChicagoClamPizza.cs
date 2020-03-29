using System;

namespace Factory_Pattern.Pizzas
{
    public class ChicagoClamPizza : Pizza
    {
        public ChicagoClamPizza()
        {
            Name = "Chicago Style Deep Dish Clam Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella and Parmesan Cheese, ");
            Toppings.Add("Fresh Clams");
        }

        new void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}