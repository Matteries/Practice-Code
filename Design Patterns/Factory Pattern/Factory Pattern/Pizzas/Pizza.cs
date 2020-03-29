using System;
using System.Collections.Generic;

namespace Factory_Pattern.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing: {Name}");
            Console.WriteLine($"Tossing: {Dough}");
            Console.WriteLine($"Adding: {Sauce}");
            Console.WriteLine($"Adding toppings: ");
            Toppings.ForEach(x => Console.WriteLine($" {x}"));
        }

        public virtual void Bake()
        {
            Console.WriteLine("Baking for approximately 25 minutes");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Placing pizza in official PizzaStore box......");
        }
    }
}