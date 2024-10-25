using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class AsyncIEnumerableDemo
    {


        //public async IAsyncEnumerable<string> GetData()
        //{
        //    //string[] items = new string[] { "Apple", "Banana", "Mango" };
            
        //}


        //public IEnumerable<string> GetNames()
        //{
        //    return new string[] { "Apple", "Banana", "Mango" };
        //}

        public async void Execute()
        {


            int number = 100;

            var result = (object)number; // value type to ref

            int output = (int) result;   // ref to value


            ArrayList arrayList = new ArrayList();

            arrayList.Add(number);
            arrayList.Add("sdf");



        }
    }
}
