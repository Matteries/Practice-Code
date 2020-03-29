using Factory_Pattern.Pizzas;
using System;

namespace Factory_Pattern.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == "Cheese")
            {
                pizza = new NYCheesePizza();
            }

            else if (pizzaType == "Clam")
            {
                pizza = new NYClamPizza();
            }

            else if (pizzaType == "Pepperoni")
            {
                pizza = new NYPepperoniPizza();
            }

            else if (pizzaType == "Veggie")
            {
                pizza = new NYVeggiePizza();
            }
            else
            {
                Console.WriteLine("Error: Sorry, the NY store does not stock that pizza");
            }

            return pizza;
        }
    }
}