using System;
using Paterns.Models;

namespace Paterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            //AnimalBase animal = new Bird();
            //dog.Go();
            //animal.Print();
            //AnimalBase animalBase = new AnimalBase();
            //animalBase.Name1
            //MyConstructor myConstructor = new MyConstructor();
            //myConstructor.Id;

            //AnimalBaseAbstractChild3 child3 = new AnimalBaseAbstractChild3(new DateTime(2020, 01, 1));
            //Console.WriteLine(child3.dt.ToString());
            #endregion

            #region
            /*IFanFactory MySimpleFanFactory = new FanFactory();
            IFan fan = MySimpleFanFactory.CreateFan(FanType.OfficeFan);
            fan.SwitchOn();
            fan = MySimpleFanFactory.CreateFan(FanType.HairFan);
            fan.SwitchOn();

            IPetFactory petFactory = new PetFactory();
            IPet pet = petFactory.Create(PetType.Cat);
            pet.Talk();

            Console.ReadLine();*/

            /*IFanFactory2 factory2 = new PCFanFactory();
            IFan2 fan = factory2.CreateFan();
            fan.SwitchOn();

            factory2 = new AutoFanFactory();
            fan = factory2.CreateFan();
            fan.SwitchOn();

            IPetFactory2 petFactory2 = new CatFactory2();
            IPet2 pet2 = petFactory2.CreatePet();
            pet2.Sound();*/

            /*IElectricalFactory electricalFactory = new KazakhType();
            IFan3 fan3 = electricalFactory.GetFan();
            fan3.SwitchOn();*/
            #endregion

            //Singleton singleton1 = new Singleton();
            //Singleton singleton2 = new Singleton();

            /*var mySingleton1 = Singleton.CreateOrGetInstance();
            //Console.WriteLine(mySingleton1.ToString());
            var getHash1 = mySingleton1.GetHashCode().ToString();
            
            var mySingleton2 = Singleton.CreateOrGetInstance();
            //Console.WriteLine(mySingleton2.ToString());
            var getHash2 = mySingleton2.GetHashCode().ToString();

            //Console.WriteLine(getHash1.ToString());
            //Console.WriteLine(getHash2.ToString());
            Console.WriteLine(mySingleton1.Equals(mySingleton2));*/

            /*Barista barista = new Barista();
            CoffeeBuilder coffeeBuilder = new Capuchino();
            var capuchino = barista.MakeCoffee(coffeeBuilder);
            Console.WriteLine(capuchino.ToString());*/

            /*Baker baker = new Baker();
            BakedGoodsBuilder bakedGoodsBuilder = new Bread();
            var bread = baker.MakeBakedGoods(bakedGoodsBuilder);
            Console.WriteLine(bread.ToString());

            bakedGoodsBuilder = new Lavash();
            var lavash = baker.MakeBakedGoods(bakedGoodsBuilder);
            Console.WriteLine(lavash.ToString());*/

            /*ICoffee coffee = new Capuchino2(50, 50, 50, 50);
            ICoffee coffee_clone = coffee.Clone();
            coffee_clone.GetInfo();
            //coffee.GetInfo();

            coffee = new Espresso2(50, 20, 50, 0);
            coffee_clone = coffee.Clone();
            coffee_clone.GetInfo();*/

            /*MyFan myFan = new MyFan(new TableFan4());
            myFan.MyFanWork();*/

            //Capuchino3 capuchino = new Capuchino3();
            //Espresso3 espresso = new Espresso3();
            //capuchino.Make();
            //espresso.Make();

            /*CoffeeMaking someCoffeeDrink = new Capuchino3();
            someCoffeeDrink.Make();
            someCoffeeDrink = new Espresso3();
            someCoffeeDrink.Make();
            Console.WriteLine();

            BreadMaking breadMaking = new Bun2();
            breadMaking.Make();*/

            CoffeeDrink2 coffeeDrink = new Espresso4();
            coffeeDrink = new LikerCoffee(coffeeDrink);
            Console.WriteLine(coffeeDrink.Name + " -  D = " + coffeeDrink.GetCost());

            Pizza pizza = new Pepperoni();
            pizza = new HellishSpicyPizza(pizza);
            Console.WriteLine(pizza.Name + " - " + pizza.GetSize());



            Console.ReadLine();
        }
    }
}
