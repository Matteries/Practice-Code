using Decorator_Pattern.Superclass;

namespace Decorator_Pattern.Components
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}