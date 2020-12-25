namespace Paterns.Models
{
    abstract class Pizza
    {
        public string Name { get; set; }
        public Pizza(string name)
        {
            Name = name;
        }

        public abstract int GetSize();
    }

    class Pepperoni : Pizza
    {
        public Pepperoni() : base("Pepperoni")
        {

        }

        public override int GetSize()
        {
            return 30;
        }
    }

    class Margarita : Pizza
    {
        public Margarita() : base("Margarita")
        {

        }

        public override int GetSize()
        {
            return 20;
        }
    }

    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string name, Pizza _pizza) : base(name)
        {
            pizza = _pizza;
        }
    }

    class SpicyPizza : PizzaDecorator
    {
        public SpicyPizza(Pizza pizza) : base(pizza.Name + ", острая", pizza)
        {

        }

        public override int GetSize()
        {
            return 30;
        }
    }

    class VerySpicyPizza : PizzaDecorator
    {
        public VerySpicyPizza(Pizza pizza) : base(pizza.Name + ", ооочень острая пицца", pizza)
        {

        }

        public override int GetSize()
        {
            return 30 * 2;
        }
    }

    class HellishSpicyPizza : PizzaDecorator
    {
        public HellishSpicyPizza(Pizza pizza) : base(pizza.Name + ", адски острая пицца, твои вкусовые рецепторы сожгутся мнговенно, в аду нет такого адского котла, как эта пицца", pizza)
        {

        }

        public override int GetSize()
        {
            return 100;
        }
    }

}