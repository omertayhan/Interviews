namespace AbstractVsInterface
{
    // interfacelerin içerisinde kod bulunmaz, sözleşmeler bulunur
    public interface IVehicle
    // interface c# 8 den sonrasında static metotlar yazılabiliyor 
    {
        void Go();
        void Stop();
    }

    public interface IRideable
    {
        void Ride();
    }

    public interface IFlyable
    {
        void Soar();
    }

    public abstract class BaseVehicle : IVehicle
    {
        public void Go()
        {
            Console.WriteLine("Vehicle is going..");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle is stopped..");
        }
    }

    public class Car : BaseVehicle
    {

    }

    public class Bike : BaseVehicle, IRideable
    // Bir class birden fazla interface implemente edilebiliyorken(interface), sadece tek bir classtan inherit edebiliriz(abstract)
    {
        public void Ride()
        {
            throw new NotImplementedException();
        }
    }

    public class Plane : BaseVehicle, IFlyable
    {
        public void Soar() // Süzülmek
        {
            throw new NotImplementedException();
        }
    }

}
