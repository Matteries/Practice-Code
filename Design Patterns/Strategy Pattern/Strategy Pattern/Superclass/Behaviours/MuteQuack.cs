using Strategy_Pattern.Superclass.Behaviours.Interfaces;
using System;

namespace Strategy_Pattern.Superclass.Behaviours
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}