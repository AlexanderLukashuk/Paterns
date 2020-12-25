namespace Paterns.Models
{
    abstract class CoffeeDrink2
    {
        public string Name { get; set; }
        public CoffeeDrink2(string name)
        {
            Name = name;
        }

        public abstract int GetCost();
    }

    class Capuchino4 : CoffeeDrink2
    {
        public Capuchino4() : base("This is capuchino")
        {

        }
        public override int GetCost()
        {
            return 500;
        }
    }

    class Espresso4 : CoffeeDrink2
    {
        public Espresso4() : base("This is espresso")
        {

        }

        public override int GetCost()
        {
            return 300;
        }
    }

    abstract class CoffeeDrinkDecorator : CoffeeDrink2
    {
        protected CoffeeDrink2 coffeeDrink;
        public CoffeeDrinkDecorator(string name, CoffeeDrink2 _coffeeDrink) : base(name)
        {
            coffeeDrink = _coffeeDrink;
        }
    }

    class LikerCoffee : CoffeeDrinkDecorator
    {
        public LikerCoffee(CoffeeDrink2 _coffeeDrink) : base(_coffeeDrink.Name + ", с ликером", _coffeeDrink)
        {

        }

        public override int GetCost()
        {
            return coffeeDrink.GetCost() + 400;
        }
    }

    class MilkCoffee : CoffeeDrinkDecorator
    {
        public MilkCoffee(CoffeeDrink2 _coffeeDrink) : base(_coffeeDrink.Name + ", с молоком", _coffeeDrink)
        {

        }

        public override int GetCost()
        {
            return coffeeDrink.GetCost() + 100;
        }
    }

    public class Decorator
    {
        
    }
}