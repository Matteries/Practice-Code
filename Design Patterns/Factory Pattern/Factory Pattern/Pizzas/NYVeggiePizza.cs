namespace Factory_Pattern.Pizzas
{
    public class NYVeggiePizza : Pizza
    {
        public NYVeggiePizza()
        {
            Name = "NY Style Sauce and Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Mushrooms");
            Toppings.Add("Onion");
            Toppings.Add("Red Peppers");
        }
    }
}