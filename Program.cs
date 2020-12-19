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


            IFanFactory MySimpleFanFactory = new FanFactory();
            IFan fan = MySimpleFanFactory.CreateFan(FanType.OfficeFan);
            fan.SwitchOn();

            IPetFactory petFactory = new PetFactory();
            IPet pet = petFactory.Create(PetType.Cat);
            pet.Talk();

            Console.ReadLine();
        }
    }
}
