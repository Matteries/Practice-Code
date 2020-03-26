using Decorator_Pattern.Superclass;

namespace Decorator_Pattern.Decorators.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Mocha";
    }
}