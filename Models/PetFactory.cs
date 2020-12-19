using System;

namespace Paterns.Models
{
    public enum PetType
    {
        Cat,
        Dog
    }

    public interface IPet
    {
        public void Talk();
    }

    public class CatP : IPet
    {
        public void Talk()
        {
            Console.WriteLine("Meow");
        }
    }

    public class DogP : IPet
    {
        public void Talk()
        {
            Console.WriteLine("Woof");
        }
    }

    public interface IPetFactory
    {
        IPet Create(PetType pet);
    }

    public class PetFactory : IPetFactory
    {
        public IPet Create(PetType pet)
        {
            switch(pet)
            {
                case PetType.Cat:
                {
                    return new CatP();
                }
                case PetType.Dog:
                {
                    return new DogP();
                }
                default:
                {
                    return new CatP();
                }
            }
        }
    }
}