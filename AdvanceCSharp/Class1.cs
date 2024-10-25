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
            throw new NotImplementedException();
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
        public void connect()
        {
            Console.WriteLine("Connecting to SQL DB");
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


    public class MongoDBDatabase : IDatabase
    {
        public void connect()
        {
            Console.WriteLine("Connecting to mongo DB");
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
            IExecutableClass e   = new PrototypeDemo();
            e.Execute();
            Console.ReadLine();
        }

        public static void SwimingExecution(ISwimmer swimmer)
        {

            swimmer.swim();
        }
    }
}
