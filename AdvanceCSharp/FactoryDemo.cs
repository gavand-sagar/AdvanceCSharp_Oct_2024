using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public interface IVehicle { 
    
    }

    public static class Factory
    {
        static Dictionary<string, Func<IVehicle>> _items = new Dictionary<string, Func<IVehicle>>();
        static Factory() {
            _items.Add("SUV", GetSUV);
            _items.Add("Bike", GetBike);
            _items.Add("Truck", GetTruck);
        }

        private static IVehicle GetSUV()
        {
            return new SUV();
        }

        private static IVehicle GetBike()
        {
            return new Bike();
        }

        public static IVehicle GetVehicle(string v)
        {
            return _items[v]?.Invoke();
        }

        public static Car GetCar()
        {
            return new Car();
        }

        internal static Truck GetTruck()
        {
            return new Truck(new MongoDBDatabase(new ConsoleLogger())) ;
        }
    }

    internal class Truck : IVehicle
    {
        public Truck(IDatabase db)
        {

        }

        internal void run()
        {
            throw new NotImplementedException();
        }
    }

    internal class Bike : IVehicle
    {
    }

    public class SUV : IVehicle
    {
    }

    public class FactoryDemo
    {
        public void Execute()
        {
            Car c = Factory.GetCar(); //new Car();
            Truck truck1 = Factory.GetTruck() ;
            Truck truck2 = Factory.GetTruck() ;

            if(truck1 == truck2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
