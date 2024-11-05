using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{




    public interface IWalker
    {
        void walk();
    }

    public interface ISwimmer
    {
        void swim();
    }

    public interface IFlyer
    {
        void fly();
    }

    public class Dog : IWalker, ISwimmer
    {

        public void swim()
        {
            throw new NotImplementedException();
        }

        public void walk()
        {
           Console.WriteLine("This is a dog, trying to walk.");
        }
    }
    public class Duck : ISwimmer, IWalker
    {
        public void swim()
        {
            throw new NotImplementedException();
        }

        public void walk()
        {

        }
    }


    public class Bird : IWalker, ISwimmer, IFlyer
    {
        public void fly() { }

        public void swim() { }

        public void walk() { }


    }














    public interface IDatabase
    {
        void connect();
        void saveEntity(object o);
        void deleteEntity(object o);
        void updateEntity(object id, object o);
    }

    public interface IEntityOperations
    {

    }


    public class SQLDatabase : IDatabase, IEntityOperations
    {
        ILogger logger;
        public void connect()
        {
            logger.Log("Connecting to SQL DB");
        }

        public SQLDatabase(ILogger logger)
        {
            this.logger = logger;
        }
        public void deleteEntity(object o)
        {
            throw new NotImplementedException();
        }

        public void saveEntity(object o)
        {
            Console.WriteLine("Save entity in SQL DB and here is the code for that");
        }

        public void updateEntity(object id, object o)
        {
            throw new NotImplementedException();
        }
    }
    public  interface ILogger {
        void Log(object message);
    }

    public class ConsoleLogger : ILogger
    {

        public void Log(object message)
        {
            Console.WriteLine(message);
        }
    }


    public class MongoDBDatabase : IDatabase
    {
        ILogger logger;
        public void connect()
        {
            logger.Log("Connecting to mongo DB");
        }

        public MongoDBDatabase(ILogger logger)
        {
            this.logger = logger;
        }

        public void deleteEntity(object o)
        {
            throw new NotImplementedException();
        }

        public void saveEntity(object o)
        {
            Console.WriteLine("Save entity in mongo DB and here is the code for that");
        }

        public void updateEntity(object id, object o)
        {
            throw new NotImplementedException();
        }
    }


    public class Class1
    {


        static void BeforeStart()
        {
            Console.WriteLine("This is Iron Man");
        }

        static void OnSuccess()
        {
            Console.WriteLine("This is Bat Man");
        }
        static void OnErrorLogic()
        {
            Console.WriteLine("Error handling");
        }



        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILogger, ConsoleLogger>();
            serviceCollection.AddSingleton<IDatabase, MongoDBDatabase>();
            serviceCollection.AddSingleton<IWalker, Dog>();
            
            serviceCollection.AddSingleton<IExecutableClass, DependencyInjectionDemo>();


            MyContainer.ServiceProvider = serviceCollection.BuildServiceProvider();
            IExecutableClass e = MyContainer.ServiceProvider.GetService<IExecutableClass>();
            e.Execute();
            Console.ReadLine();
        }

        public static void SwimingExecution(ISwimmer swimmer)
        {

            swimmer.swim();
        }
    }
}
