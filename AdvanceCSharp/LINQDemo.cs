using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class LINQDemo
    {
        public void Execute()
        {

            // SQL -> "select Upper(p.productCode) from products p"
            // LINQ -> 


            List<string> list1 = new List<string>() { "Sagar", "Suraj", "Amit", "Rohan", "Rahul", "Jay", "Rohit", "Mayur" };

            //var result = (from ls in list1
            //              where ls.StartsWith("S")
            //              orderby ls
            //              select ls                          
            //              ); ;


            //var result = list1
            //    .Select(item => "$." + item ).ToList();

            //var result = list1
            //    .Select((string item) =>
            //    {
            //        return "$." + item;
            //    }).ToList();



            list1.Where(ls => ls.StartsWith("R"))
            .OrderByDescending(ls => ls)
            .Select(ls => ls.ToUpper());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1 });
            products.Add(new Product { Id = 2 });
            products.Add(new Product { Id = 3 });

            var result = products.Where(x => x.Id == 1).Select(x=>x.Id) ;
            result.ToList();
            //products.ForEach(p =>
            //{
            //    if(p.Id == 1)
            //    {
            //        p.Id = 111;
            //    }
            //});




            foreach (var item in products)
            {
                Console.WriteLine(item.Id);
            }

        }

        //static string myFun(string item)
        //{ 
        //    return "$." + item; 
        //}

        static Func<string, string> myFun = (string item) =>
        {
            return "$." + item;
        };
    }
}
