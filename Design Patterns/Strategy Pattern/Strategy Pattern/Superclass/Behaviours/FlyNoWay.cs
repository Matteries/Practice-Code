using Strategy_Pattern.Superclass.Behaviours.Interfaces;
using System;

namespace Strategy_Pattern.Superclass.Behaviours
{
    public class FlyNoWay : IFlyBehaviour
    {
        void IFlyBehaviour.Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}