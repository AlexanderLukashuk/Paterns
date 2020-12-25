using System;

namespace Paterns.Models
{
    abstract class CoffeeMaking
    {
        public void Make()
        {
            GetName();
            AddCoffee();
            AddWater();
            AddMilk();
            AddSugar();
            GetReadyDrink();
        }

        public abstract string Name { get; }
        public abstract void GetName();
        public abstract void AddWater();
        public abstract void AddCoffee();
        public abstract void AddMilk();
        public abstract void AddSugar();
        public virtual void GetReadyDrink()
        {
            Console.WriteLine("Получили кофейный напиток");
        }
    }

    class Capuchino3 : CoffeeMaking
    {
        public override string Name
        {
            get
            {
                return "Capuchino";
            }
        }
        public override void GetName()
        {
            Console.WriteLine("Добавляем " + this.Name);
        }
        public override void AddWater()
        {
            Console.WriteLine("Добавляем кипяченую воду");
        }
        public override void AddCoffee()
        {
            Console.WriteLine("Добавляем свежемолотый кофе");
        }
        public override void AddMilk()
        {
            Console.WriteLine("Добавляем молоко");
        }
        public override void AddSugar()
        {
            Console.WriteLine("Добавляем сахар");
        }
    }

    class Espresso3 : CoffeeMaking
    {
        public override string Name
        {
            get
            {
                return "Espresso";
            }
        }
        public override void GetName()
        {
            Console.WriteLine("Добавляем " + this.Name);
        }
        public override void AddWater()
        {
            Console.WriteLine("Добавляем кипяченую воду");
        }
        public override void AddCoffee()
        {
            Console.WriteLine("Добавляем свежемолотый кофе");
        }
        public override void AddMilk()
        {
            Console.WriteLine("Не добавляем молоко");
        }
        public override void AddSugar()
        {
            Console.WriteLine("Добавляем сахар");
        }
    }

    public class Template
    {

    }
}