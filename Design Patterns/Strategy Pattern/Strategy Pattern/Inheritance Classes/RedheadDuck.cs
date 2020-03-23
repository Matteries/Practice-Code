using System;
using Strategy_Pattern.Superclass;
using Strategy_Pattern.Superclass.Behaviours;

namespace Strategy_Pattern.Inheritance_Classes
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            QuackBehaviour = new Quack();
            FlyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real RedheadDuck");
        }
    }
}