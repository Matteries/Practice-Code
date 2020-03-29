using Factory_Pattern.PizzaStores;
using System;

namespace Factory_Pattern
{
    public class PizzaTestDrive
    {
        public static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            var nyPizzaOrder = nyStore.OrderPizza("Cheese");
            Console.WriteLine($"Ethan ordered a {nyPizzaOrder.Name} \n");

            var chicagoPizzaOrder = chicagoStore.OrderPizza("Pepperoni");
            Console.WriteLine($"Joel ordered a {chicagoPizzaOrder.Name} \n");

            Console.ReadKey();
        }
    }
}