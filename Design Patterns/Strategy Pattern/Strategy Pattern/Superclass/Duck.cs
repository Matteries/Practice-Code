using Strategy_Pattern.Superclass.Behaviours.Interfaces;
using System;

namespace Strategy_Pattern.Superclass
{
    public abstract class Duck
    {
        public IQuackBehaviour QuackBehaviour { get; set; }
        public IFlyBehaviour FlyBehaviour { get; set; }

        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }

        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("I am swimming - All ducks can float, even a decoy!");
        }
    }
}