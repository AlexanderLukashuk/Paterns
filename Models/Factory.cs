using System;

namespace Paterns.Models
{
    public enum FanType
    {
        TableFan,
        PCFan,
        HairFan,
        OfficeFan
    }
    public interface IFan
    {
        void SwitchOn();
        void SwitchOff();
    }

    public class TableFan : IFan
    {
        public void SwitchOn()
        {
            Console.WriteLine("TableFan Switched On");
        }

        public void SwitchOff()
        {
            Console.WriteLine("TableFan Switched Off");
        }
    }

    public class PCFan : IFan
    {
        public void SwitchOn()
        {
            Console.WriteLine("PCFan Switched On");
        }

        public void SwitchOff()
        {
            Console.WriteLine("PCFan Switched Off");
        }
    }

    public class HairFan : IFan
    {
        public void SwitchOn()
        {
            Console.WriteLine("HairFan Switched On");
        }

        public void SwitchOff()
        {
            Console.WriteLine("HairFan Switched Off");
        }
    }

    public class OfficeFan : IFan
    {
        public void SwitchOn()
        {
            Console.WriteLine("OfficeFan Switched On");
        }

        public void SwitchOff()
        {
            Console.WriteLine("OfficeFan Switched Off");
        }
    }

    public interface IFanFactory
    {
        IFan CreateFan(FanType fanType);
    }

    public class FanFactory : IFanFactory
    {
        public IFan CreateFan(FanType fanType)
        {
            switch (fanType)
            {
                case FanType.TableFan:
                    {
                        return new TableFan();
                    }
                case FanType.PCFan:
                    {
                        return new PCFan();
                    }
                case FanType.HairFan:
                    {
                        return new HairFan();
                    }
                case FanType.OfficeFan:
                    {
                        return new OfficeFan();
                    }
                default:
                    {
                        return new TableFan();
                    }
            }
        }
    }


    //*
    //* Factory
    //* 1) Factory Simple
    //* 2) Factory Method
    //* 3) Abstract Factory
    //* 
    //* 
    //* 
    //* FanFactory
    //* 
    //* 

}