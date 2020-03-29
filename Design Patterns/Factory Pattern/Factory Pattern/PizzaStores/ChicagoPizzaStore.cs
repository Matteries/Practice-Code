using Factory_Pattern.Pizzas;
using System;

namespace Factory_Pattern.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == "Cheese")
            {
                pizza = new ChicagoCheesePizza();
            }

            else if (pizzaType == "Clam")
            {
                pizza = new ChicagoClamPizza();
            }

            else if (pizzaType == "Pepperoni")
            {
                pizza = new ChicagoPepperoniPizza();
            }

            else if (pizzaType == "Veggie")
            {
                pizza = new ChicagoVeggiePizza();
            }

            else
            {
                Console.WriteLine("Error: Sorry, the Chicago store does not stock that pizza");
            }

            return pizza;
        }
    }
}