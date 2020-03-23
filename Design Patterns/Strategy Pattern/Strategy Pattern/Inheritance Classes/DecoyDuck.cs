using Strategy_Pattern.Superclass;
using Strategy_Pattern.Superclass.Behaviours;
using System;

namespace Strategy_Pattern.Inheritance_Classes
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehaviour = new MuteQuack();
            FlyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I am a decoy duck");
        }
    }
}