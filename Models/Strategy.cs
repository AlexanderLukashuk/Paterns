using System;

namespace Paterns.Models
{
    public interface IFan4
    {
        void Work();
    }

    public class TableFan4 : IFan4
    {
        public void Work()
        {
            Console.WriteLine("настолный вентилтор работает");
        }
    }

    public class HairFan4 : IFan4
    {
        public void Work()
        {
            Console.WriteLine("фен работает");
        }
    }
    
    public class MyFan
    {
        IFan4 Fan;
        public MyFan(IFan4 fan)
        {
            Fan = fan;

        }

        public void MyFanWork()
        {
            Fan.Work();
        }
    }

    public class Strategy
    {
        
    }
}