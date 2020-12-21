using System;

namespace Paterns.Models
{
    public interface IPet2
    {
        void Sound();
    }

    public class Cat2 : IPet2
    {
        public void Sound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Dog2 : IPet2
    {
        public void Sound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Bird2 : IPet2
    {
        public void Sound()
        {
            Console.WriteLine("Chirik-chirik");
        }
    }

    public interface IPetFactory2
    {
        IPet2 CreatePet();
    }

    public class CatFactory2 : IPetFactory2
    {
        public IPet2 CreatePet()
        {
            return new Cat2();
        }
    }

    public class DogFactory2 : IPetFactory2
    {
        public IPet2 CreatePet()
        {
            return new Dog2();
        }
    }

    public class BirdFactory2 : IPetFactory2
    {
        public IPet2 CreatePet()
        {
            return new Bird2();
        }
    }

    public class PetFactory2
    {
        
    }
}