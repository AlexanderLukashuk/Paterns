using System;
using System.Text;

namespace Paterns.Models
{
    class Capuchino : CoffeeBuilder
    {
        public override void AddCoffee()
        {
            Drink.coffee = new Coffee() { Name = "Arabica"};
        }

        public override void AddWater()
        {
            Drink.water = new Water() { Name = "some water"};
        }

        public override void AddSugar()
        {
            Drink.sugar = new Sugar() { Name = "Some sugar for capchino"};
        }

        public override void AddMilk()
        {
            Drink.milk = new Milk() { Name = "Some wilk with foam"};
        }
    }

    class Espresso : CoffeeBuilder
    {
        public override void AddCoffee()
        {
            Drink.coffee = new Coffee() { Name = "Arabica"};
        }

        public override void AddWater()
        {
            Drink.water = new Water() { Name = "Some water"};
        }

        public override void AddSugar()
        {
            Drink.sugar = new Sugar() { Name = "Some sugar for espresso"};
        }

        public override void AddMilk()
        {
            Drink.milk = new Milk() { Name = "No milk"};
        }
    }

    class Barista
    {
        public CoffeeDrink MakeCoffee(CoffeeBuilder coffeeBuilder)
        {
            coffeeBuilder.CreateDrink();
            coffeeBuilder.AddCoffee();
            coffeeBuilder.AddWater();
            coffeeBuilder.AddSugar();
            coffeeBuilder.AddMilk();

            return coffeeBuilder.Drink;
        }
    }

    abstract class CoffeeBuilder
    {
        public CoffeeDrink Drink { get; set; }
        public void CreateDrink()
        {
            Drink = new CoffeeDrink();
        }

        public abstract void AddCoffee();
        public abstract void AddWater();
        public abstract void AddSugar();
        public abstract void AddMilk();
    }

    class CoffeeDrink
    {
        public Coffee coffee { get; set; }
        public Water water { get; set; }
        public Sugar sugar { get; set; }
        public Milk milk { get; set; }

        public override string ToString()
        {
            string result = coffee.Name + Environment.NewLine +
                water.Name + Environment.NewLine +
                sugar.Name + Environment.NewLine +
                milk.Name + Environment.NewLine;
            return result;
        }
    }

    class Coffee
    {
        public string Name { get; set; }
    }

    class Water
    {
        public string Name { get; set; }
    }

    class Sugar
    {
        public string Name { get; set; }
    }

    class Milk
    {
        public string Name { get; set; }
    }

    public class Builder
    {
        
    }
}