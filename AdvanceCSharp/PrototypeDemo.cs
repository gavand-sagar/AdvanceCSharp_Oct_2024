using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class PrototypeDemo : IExecutableClass
    {

        public class CatFactResponse
        {
            public string Fact { get; set; }
            public int Length { get; set; }
        }

        public class CatFact : ICloneable<CatFact>
        {
            public string Fact { get; set; }

            public CatFact()
            {
                HttpClient httpClient = new HttpClient();
                Task.Delay(2000).Wait();
                this.Fact = httpClient.GetFromJsonAsync<CatFactResponse>("https://catfact.ninja/fact").Result.Fact;
            }

            public CatFact(string fact)
            {
                this.Fact = fact;
            }
            
            public CatFact Clone()
            {
                return new CatFact(this.Fact);
            }
        }

        public void Execute()
        {
            Console.WriteLine("Creating object of user");
            CatFact f1 = new CatFact();
            Console.WriteLine("Created object of user");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Creating second object of user");
            CatFact f2 = f1.Clone();  /// copies the reference which is not good //
            Console.WriteLine("Created second object of user");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Creating third object of user");
            CatFact f3 = f1.Clone();
            Console.WriteLine("Created third object of user");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Creating fourth object of user");
            CatFact f4 = f1.Clone();
            Console.WriteLine("Created fourth object of user");
        }
    }
}
