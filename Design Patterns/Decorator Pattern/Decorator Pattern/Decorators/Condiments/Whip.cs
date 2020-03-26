using Decorator_Pattern.Superclass;

namespace Decorator_Pattern.Decorators.Condiments
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Whip";
    }
}