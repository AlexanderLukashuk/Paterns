using System;

namespace Paterns.Models
{
    public interface ICoffee
    {
        ICoffee Clone();
        void GetInfo();
    }

    public class Capuchino2 : ICoffee
    {
        int Coffee;
        int Water;
        int Sugar;
        int Milk;

        public Capuchino2(int coffee, int water, int sugar, int milk)
        {
            Coffee = coffee;
            Water = water;
            Sugar = sugar;
            Milk = milk;
        }

        public ICoffee Clone()
        {
            return new Capuchino2(Coffee, Water, Sugar, Milk);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Capuchino2: Coffee: {Coffee.ToString()}, Water: {Water.ToString()}, Sugar: {Sugar.ToString()}, Milk: {Milk.ToString()}");
        }
    }

    public class Espresso2 : ICoffee
    {
        int Coffee;
        int Water;
        int Sugar;
        int Milk;

        public Espresso2(int coffee, int water, int sugar, int milk)
        {
            Coffee = coffee;
            Water = water;
            Sugar = sugar;
            Milk = milk;
        }

        public ICoffee Clone()
        {
            return new Espresso2(Coffee, Water, Sugar, Milk);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Espresso2: Coffee: {Coffee.ToString()}, Water: {Water.ToString()}, Sugar: {Sugar.ToString()}, Milk: {Milk.ToString()}");
        }
    }

    public class Prototype
    {

    }
}