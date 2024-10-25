using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{

    public class LoggerService
    {

        private static LoggerService instance = null;
        private LoggerService()
        {

        }

        public static LoggerService GetLogger()
        {
            if (instance == null)
            {
                instance = new LoggerService();
            }
            return instance;
        }

    }


    public class SingleTone
    {
        private static Dictionary<Type, object> instances = new Dictionary<Type, object>();


        public static T GetInstance<T>() where T : class
        {
            if (!instances.ContainsKey(typeof(T)))
            {
                instances.Add(typeof(T), Activator.CreateInstance<T>());
            }
            return (T)instances[typeof(T)];
        }

        public static void Register<T>(T obj) where T : class
        {
            instances.Add(typeof(T), obj);
        }

    }



    public class SingletoneDemo
    {
        public void Execute()
        {
            SingleTone.Register<Car>(new Car());

            SingleTone.GetInstance<Car>();
            SingleTone.GetInstance<Car>();
            SingleTone.GetInstance<Car>();



            Product p1 = SingleTone.GetInstance<Product>();            
            Product p2 = SingleTone.GetInstance<Product>();

            Product p3 = new Product();
                       

            if (p1 == p2 && p2 == p3)
            {
                Console.WriteLine("Same instances");
            }

        }
    }
}
