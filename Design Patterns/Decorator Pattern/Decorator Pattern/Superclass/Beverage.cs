namespace Decorator_Pattern.Superclass
{
    public abstract class Beverage
    {
        public abstract double Cost();

        public virtual string Description { get; protected set; } = "Unknown Beverage";
    }
}