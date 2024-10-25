using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{

    struct Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class MyClass : IDisposable
    {
        public MyClass() { 
        
        }
        public void Dispose()
        {

        }
    }
    public class Car : IDisposable
    {
        //constructor

        string BigString = "Superman";
        Product p;
        public Car() {
            // when the object will be created
            p = new Product(); 
            Console.WriteLine("Created");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose Method Called");
            BigString = null;
            p = null;
            Console.WriteLine("Resources Cleaned up.");
        }


        public void Display()
        {
            Console.WriteLine("This is a Car....");
        }



        //~Car()
        //{
        //    BigString = null;
        //}

    }

    public class DestructorDemo
    {
        public async Task Execute()
        {
            TestMethod();
            Console.WriteLine("Program Ended");
        }


        private void TestMethod()
        {
            using (Car c = new Car())
            using (MyClass p = new MyClass())
            {

                int sum = 2 - 2;
                int res = 10 / sum;
                Console.WriteLine("THIS IS VERY IMPORTANT LINE");
            }
           
        }
    }
}
