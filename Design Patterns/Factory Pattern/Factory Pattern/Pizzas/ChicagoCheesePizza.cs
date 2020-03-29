using System;

namespace Factory_Pattern.Pizzas
{
    public class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella and Parmesan Cheese");
        }

        new void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}