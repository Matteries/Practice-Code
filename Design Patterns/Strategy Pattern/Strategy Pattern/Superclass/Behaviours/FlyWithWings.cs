using Strategy_Pattern.Superclass.Behaviours.Interfaces;
using System;

namespace Strategy_Pattern.Superclass.Behaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        void IFlyBehaviour.Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}