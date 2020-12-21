namespace Paterns.Models
{
    public interface IFan3
    {
        void SwitchOn();
    }

    public interface IKazakhLight
    {
        void Sample();
    }

    public class EuroFan : IFan3
    {
        public void SwitchOn()
        {

        }
    }

    public class Kazakh : IKazakhLight
    {
        public void Sample()
        {

        }
    }

    public interface IElectricalFactory
    {
        IFan3 GetFan();
        IKazakhLight GetKazakhLight();
    }

    public class KazakhType : IElectricalFactory
    {
        public IFan3 GetFan()
        {
            return new EuroFan();
        }
        public IKazakhLight GetKazakhLight()
        {
            return new Kazakh();
        }
    }

}