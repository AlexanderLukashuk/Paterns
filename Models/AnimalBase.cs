using System;
using System.Collections.Generic;

namespace Paterns.Models
{
    public interface ITest2<T, Q> where T : AnimalBase where Q : class
    {
        T getById(int id);
        IEnumerable<T> getAll();
        void Create(T t);
        void Update(int id, T t);
        void Delete(int id);
        Q getConnect(string connectionString);
    }

    public interface ITest<T> where T : AnimalBase
    {
        T getById(int id);
        IEnumerable<T> getAll();
        void Create(T t);
        void Update(int id, T t);
        void Delete(int id);
    }

    public class DogService : ITest<Dog>
    {
        public void Create(Dog t)
        {

        }

        public void Update(int id, Dog t)
        {

        }

        public void Delete(int id)
        {

        }

        public Dog getById(int id)
        {
            return new Dog();
        }

        public IEnumerable<Dog> getAll()
        {
            return null;
        }
    }

    public class Dummy
    {

    }

    public class CatService : ITest2<Cat, Dummy>
    {
        public Dummy getConnect(string connectionString)
        {
            return null;
        }
        public void Create(Cat t)
        {

        }

        public void Update(int id, Cat t)
        {

        }

        public void Delete(int id)
        {

        }

        public Cat getById(int id)
        {
            return new Cat();
        }

        public IEnumerable<Cat> getAll()
        {
            return null;
        }
    }

    //? абстрактный класс должен стоять впереди интерфейса при наследовании
    public class Inherited : AnimalBaseAbstract, IMyInterface1, IMyInterface2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Method1() {}
        public string Method2() { return null; }
        public string Method3() { return null; }

        public override string get1()
        {
            return null;
        }
    }

    public interface IMyInterface1
    {
        //? в интерфейсе нельзя сразу же инициализировать поля, свойства в интерфейсе
        int Id { get; set; }
        string Name { get; set; }

        void Method1();
        string Method2();
    
    }
    public interface IMyInterface2
    {
        string Method2();
        string Method3();
    }

    public interface IMyInterface3 : IMyInterface1
    {
        string Method4();
    }

    public class MyConstructor
    {
        private MyConstructor()
        {

        }

        /*public MyConstructor(int id)
        {
            this.Id = id;
        }

        public MyConstructor(string id)
        {
            this.Id = int.Parse(id);
        }*/
        public int Id { get; set; }
    }

    public abstract class AnimalBaseAbstract
    {
        public DateTime dt;
        //? абстрактный класс, как и обычный класс, может иметь контруктор
        public AnimalBaseAbstract() {}
        public AnimalBaseAbstract(DateTime DT)
        {
            dt = DT;
        }
        public string Name { get; set; }
        public abstract string get1();

        //! неабстрактные методы должны иметь реализацию, тело
        //! абстрактные методы нельзя делать в неабстрактных классах
        public string get2()
        {
            return null;
        }
        public virtual string get3()
        {
            return "Print get3()";
        }
    }

    public class AnimalBaseAbstractChild1 : AnimalBaseAbstract
    {
        public override string get1()
        {
            return "AnimalBaseAbstractChild1";
        }

        string Name { get; set; } = "Astana";
    }

    public class AnimalBaseAbstractChild2 : AnimalBaseAbstract
    {
        public override string get1()
        {
            return "AnimalBaseAbstractChild2";
        }
    }

    public class AnimalBaseAbstractChild3 : AnimalBaseAbstract
    {
        public AnimalBaseAbstractChild3(DateTime DT) : base (DT) {}

        public override string get1()
        {
            return "AnimalBaseAbstractChild3";
        }
    }

    public class AnimalBase
    {
        private string Name { get; set; }
        public string Name1 { get; set; }
        protected string Name2 
        {
            //? можно только читать
            get
            {
                return "Hello";
            }
        }

        protected string Name3 { get; set; }    

        public virtual void Print()
        {
            Console.WriteLine("Print AnimalBase");
        }
    }

    public class Dog : AnimalBase
    {
        public void Go()
        {
            Console.WriteLine(Name2);
        }

        public override void Print()
        {
            Console.WriteLine("Print Dog");
        }
    }

    public class Cat : AnimalBase
    {
        public override void Print()
        {
            Console.WriteLine("Print Cat");
        }

        public void PrintCat()
        {
            Console.WriteLine("Print Cat owner");
        }
    }

    public class Bird : AnimalBase
    {

    }

    public class Cat1 : Cat
    {

    }
}