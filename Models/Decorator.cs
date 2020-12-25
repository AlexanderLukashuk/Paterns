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

    public class Decorator
    {
        
    }
}