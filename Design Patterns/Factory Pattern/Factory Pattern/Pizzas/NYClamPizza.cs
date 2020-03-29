namespace Factory_Pattern.Pizzas
{
    public class NYClamPizza : Pizza
    {
        public NYClamPizza()
        {
            Name = "NY Style Sauce and Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Fresh Clams");
        }
    }
}