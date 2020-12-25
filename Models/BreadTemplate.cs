using System;

namespace Paterns.Models
{
    public abstract class BreadMaking
    {
        public void Make()
        {
            GetName();
            AddFlour();
            AddWater();
            AddYeast();
            AddSalt();
            AddCinnamon();
            GetReadyBread();
        }

        public abstract string Name { get; }
        public abstract void GetName();
        public abstract void AddFlour();
        public abstract void AddSalt();
        public abstract void AddYeast();
        public abstract void AddWater();
        public abstract void AddCinnamon();
        public virtual void GetReadyBread()
        {
            Console.WriteLine("Получили готовый хлеб");
        }
    }

    public class Loaf2 : BreadMaking
    {
        public override string Name
        {
            get
            {
                return "Loaf";
            }
        }

        public override void GetName()
        {
            Console.WriteLine("Печем " + this.Name);
        }

        public override void AddFlour()
        {
            Console.WriteLine("Добавляем муку");
        }

        public override void AddWater()
        {
            Console.WriteLine("Добавляем воду");
        }

        public override void AddYeast()
        {
            Console.WriteLine("Добавляем дрожжи");
        }

        public override void AddSalt()
        {
            Console.WriteLine("Добавляем соль");
        }

        public override void AddCinnamon()
        {
            Console.WriteLine("Не добавляем корицу");
        }

        public override void GetReadyBread()
        {
            Console.WriteLine("Получили готовый " + this.Name);
        }
    }

    public class Bun2 : BreadMaking
    {
        public override string Name
        {
            get
            {
                return "Bun";
            }
        }

        public override void GetName()
        {
            Console.WriteLine("Печем " + this.Name);
        }

        public override void AddFlour()
        {
            Console.WriteLine("Добавляем муку");
        }

        public override void AddWater()
        {
            Console.WriteLine("Добавляем воду");
        }

        public override void AddYeast()
        {
            Console.WriteLine("Добавляем дрожжи");
        }

        public override void AddSalt()
        {
            Console.WriteLine("Добавляем соль");
        }

        public override void AddCinnamon()
        {
            Console.WriteLine("Добавляем корицу");
        }

        public override void GetReadyBread()
        {
            Console.WriteLine("Получили готовую булочку с корицей");
        }
    }

    public class BreadTemplate
    {
        
    }
}