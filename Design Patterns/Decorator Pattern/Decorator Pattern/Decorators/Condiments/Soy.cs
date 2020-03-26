using Decorator_Pattern.Superclass;

namespace Decorator_Pattern.Decorators.Condiments
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Soy";
    }
}