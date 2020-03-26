using Decorator_Pattern.Superclass;


namespace Decorator_Pattern.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}