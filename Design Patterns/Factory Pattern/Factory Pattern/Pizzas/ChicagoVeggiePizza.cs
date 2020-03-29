using System;

namespace Factory_Pattern.Pizzas
{
    public class ChicagoVeggiePizza : Pizza
    {
        public ChicagoVeggiePizza()
        {
            Name = "Chicago Style Deep Dish Veggie Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella and Parmesan Cheese");
            Toppings.Add("Eggplant");
            Toppings.Add("Spinach");
            Toppings.Add("Black Olives");
        }

        new void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}