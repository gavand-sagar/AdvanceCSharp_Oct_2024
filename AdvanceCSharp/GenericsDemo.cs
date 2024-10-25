using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{

    class MyResponse<T>
    {
        public T Data { get; set; }
        public int Status { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
    }
    public class Order
    {
        public int OrderNumber { get; set; }
    }


    class MyHistoryCollection<T> where T : class {
    
        public void Add(T item) { }

        public void Remove(T item) { }

    }

    public class GenericsDemo
    {
       public void Execute()
        {
            MyResponse<Order> myResponse = new MyResponse<Order>();
            myResponse.Status = 80;


            List<Product> products = new List<Product>();

            products.Add(new Product());
            products.Add(new Product());
            products.Add(new Product());

            Dictionary<int,string> map = new Dictionary<int,string>();

            //myResponse.Data.Id = 1;

            Console.WriteLine("hello");
        }
    }
}
