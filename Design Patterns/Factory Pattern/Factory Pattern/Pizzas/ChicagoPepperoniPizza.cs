using System;

namespace Factory_Pattern.Pizzas
{
    public class ChicagoPepperoniPizza : Pizza
    {
        public ChicagoPepperoniPizza()
        {
            Name = "Chicago Style Deep Dish Pepperoni Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella and Parmesan Cheese");
            Toppings.Add("Mushrooms");
            Toppings.Add("Onions");
            Toppings.Add("Red Peppers");
            Toppings.Add("Fresh Mushrooms");
        }

        new void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}