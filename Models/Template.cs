using System;

namespace Paterns.Models
{
    abstract class CoffeeMaking
    {
        public abstract string Name { get; set; }
        public abstract string GetName();
        public abstract string AddWater();
        public abstract string AddCoffee();
        public abstract string AddMilk();
        public abstract string AddSugar();
        public virtual void GetReadyDrink()
        {
            Console.WriteLine("Получили кофейный напиток");
        }
    }

    public class Template
    {
        
    }
}