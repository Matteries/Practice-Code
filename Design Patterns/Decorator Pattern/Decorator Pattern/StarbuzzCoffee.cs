using Decorator_Pattern.Components;
using Decorator_Pattern.Decorators.Condiments;
using Decorator_Pattern.Superclass;
using System;

namespace Decorator_Pattern
{
    public class StarbuzzCoffee
    {
        public static void Main(string[] args)
        {
            Order1();
            Order2();
            Order3();

            Console.ReadLine();
        }

        private static void Order1()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " £" + beverage.Cost());
        }

        private static void Order2()
        {
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " £" + beverage2.Cost());
        }

        private static void Order3()
        {
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " £" + beverage3.Cost());
        }
    }
}