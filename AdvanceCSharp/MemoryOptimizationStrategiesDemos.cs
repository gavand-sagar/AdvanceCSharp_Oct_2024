using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class MemoryOptimizationStrategiesDemos
    {
        public void Execute()
        {
            //StringBuilder value = new StringBuilder("");

            //for (int i = 0; i < 100; i++)
            //{
            //    value.Append(i);
            //    //value += i.ToString();
            //}

            //Console.WriteLine(value);


            //Lazy<Car> c = new Lazy<Car>();
            Car c = new Car();


            Console.WriteLine("Give Input 1/2");
            string value = Console.ReadLine();
            if (value == "1")
            {
               
                c.Display();
            }

        }
    }
}
