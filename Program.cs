using System;
using Paterns.Models;
using System.Collections.Generic;

namespace Paterns
{
    //? solid O - opened/closed - функции должны быть открыты для расширение
    //? и закрыты для изменения

    //? l - правильное наследование

    //? принцип разделения интерфейсов

    //? инверсия зависимостей - классы высокого уровня
    //? зависят от классов низкого уровня,
    //? а низкие зависят от абстрактных классов

    public class Employee
    {
        public IEmployeeReport Report;
        public Employee(IEmployeeReport report)
        {
            Report = report;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Add(Employee emp)
        {
            return true;
        }

        public void MakeReport()
        {
            Report.MakeReport(this);
        }

        //! не должны подобные методы находиться в этом классе
        /*public void MakeReportExcel(Employee emp)
        {
            ;
        }
        public void MakeReportPDF(Employee emp)
        {
            ;
        }
        public void MakeReportCSV(Employee emp)
        {
            ;
        }*/
    }


    public abstract class Emp
    {
        public virtual string GetWorkDetalis(int id)
        {
            return "Base Work";
        }
        public virtual string GetEmpDetalis(int id)
        {
            return "Base Employee";
        }
    }

    public class Senior : Emp
    {
        public override string GetWorkDetalis(int id)
        {
            return "Senior Work";
        }
        public override string GetEmpDetalis(int id)
        {
            return "Senior Employee";
        }
    }

    public class Junior : Emp
    {
        public override string GetWorkDetalis(int id)
        {
            throw new NotImplementedException();
        }
        public override string GetEmpDetalis(int id)
        {
            return "Junior Employee";
        }
    }


    /*class EmployeeReport
    {
        string TypeReport;
        public void MakeReportExcel(Employee emp)
        {
            if (TypeReport == "CSV")
            {
                ;
            }
            else if (TypeReport == "PDF")
            {
                ;
            }
            else if (TypeReport == "Excel")
            {
                ;
            }
        }
    }*/

    public interface IEmployeeReport
    {
        void MakeReport(Employee emp);
    }

    public class EmployeeReportCVS : IEmployeeReport
    {
        public void MakeReport(Employee emp)
        {
            Console.WriteLine("print in CSV format");
        }
    }

    public class EmployeeReportPDF : IEmployeeReport
    {
        public void MakeReport(Employee emp)
        {
            Console.WriteLine("print in PDF format");
        }
    }

    
    //? solid S - single responsobolity - класс выполняет только одну функцию
    //? контролирует только определенные действия
    class Country
    {
        void Add() {}
        void Del() {}
        void Select() {}
        void Update() {}

        void Travel() {}
    }

    public class Email
    {
        public void Send()
        {
            ;
        }
    }

    public class Notification
    {
        //Email email;
        IMessenger Messenger;
        public Notification(IMessenger messenger)
        {
            Messenger = new Email2();
        }
        public void EmailDistr()
        {
            Messenger.Send();
        }
    }

    public interface IMessenger
    {
        void Send();
    }

    public class Email2 : IMessenger
    {
        public void Send()
        {
            ;
        }
    }

    public class SMS : IMessenger
    {
        public void Send()
        {
            ;
        }
    }

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

            /*CoffeeDrink2 coffeeDrink = new Espresso4();
            coffeeDrink = new LikerCoffee(coffeeDrink);
            Console.WriteLine(coffeeDrink.Name + " -  D = " + coffeeDrink.GetCost());

            Pizza pizza = new Pepperoni();
            pizza = new HellishSpicyPizza(pizza);
            Console.WriteLine(pizza.Name + " - " + pizza.GetSize());*/


            //Employee employee = new Employee(new EmployeeReportPDF());
            //employee.MakeReport();

            List<Emp> list = new List<Emp>();
            list.Add(new Senior());
            list.Add(new Junior());

            foreach ( var item in list)
            {
                Console.WriteLine(item.GetEmpDetalis(123));
                Console.WriteLine(item.GetWorkDetalis(123));
            }

            Console.ReadLine();

            //? при построении всей иерархии, наследники должны правильно наследовать примеру базовых классов
            //? Наследники не должны сильно изменять базовый класс
        }
    }
}
