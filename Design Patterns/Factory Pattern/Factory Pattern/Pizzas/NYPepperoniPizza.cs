namespace Factory_Pattern.Pizzas
{
    public class NYPepperoniPizza : Pizza
    {
        public NYPepperoniPizza()
        {
            Name = "NY Style Sauce and Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Mushrooms");
            Toppings.Add("Onions");
            Toppings.Add("Red Peppers");
            Toppings.Add("Fresh Mushrooms");
        }
    }
}