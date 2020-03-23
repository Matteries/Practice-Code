using System;
using Strategy_Pattern.Superclass;
using Strategy_Pattern.Superclass.Behaviours;

namespace Strategy_Pattern.Inheritance_Classes
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehaviour = new Squeak();
            FlyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber duck!");
        }
    }
}