using Strategy_Pattern.Superclass.Behaviours.Interfaces;
using System;

namespace Strategy_Pattern.Superclass.Behaviours
{
    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}