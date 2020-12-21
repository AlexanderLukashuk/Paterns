namespace Paterns.Models
{
    public interface IFan2
    {
        void SwitchOn();
        void SwitchOff();
    }

    public class TableFan2 : IFan2
    {
        public void SwitchOn()
        {

        }   

        public void SwitchOff()
        {

        }
    }

    public class PCFan2 : IFan2
    {
        public void SwitchOn()
        {

        }   

        public void SwitchOff()
        {
            
        }
    }

    public class Fan2 : IFan2
    {
        public void SwitchOn()
        {

        }   

        public void SwitchOff()
        {
            
        }
    }

    public class AutoFan2 : IFan2
    {
        public void SwitchOn()
        {

        }   

        public void SwitchOff()
        {
            
        }
    }

    public interface IFanFactory2
    {
        IFan2 CreateFan();
    }

    class TableFanFactory : IFanFactory2
    {
        public IFan2 CreateFan()
        {
            return null;
        }


    }

    class PCFanFactory : IFanFactory2
    {
        public IFan2 CreateFan()
        {
            return null;
        }

        
    }

    class HairFanFactory : IFanFactory2
    {
        public IFan2 CreateFan()
        {
            return null;
        }

        
    }

    class AutoFanFactory : IFanFactory2
    {
        public IFan2 CreateFan()
        {
            return null;
        }

        
    }

}