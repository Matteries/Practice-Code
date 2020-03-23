using System;
using Strategy_Pattern.Superclass;
using Strategy_Pattern.Superclass.Behaviours;

namespace Strategy_Pattern.Inheritance_Classes
{
    public class CanvasbackDuck : Duck
    {
        public CanvasbackDuck()
        {
            QuackBehaviour = new Quack();
            FlyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a canvasback duck");
        }
    }
}