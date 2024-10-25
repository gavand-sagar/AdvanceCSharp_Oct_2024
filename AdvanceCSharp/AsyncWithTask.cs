using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class FactResponse
    {
        public string Fact { get; set; }
        public int Length { get; set; }
    }

    public class AsyncWithTask
    {
        public int count { get; set; } = 0;
        public async void Execute()
        {
            //string data = this.GetName().Result;
            FactResponse data = await this.GetName();

            Console.WriteLine($"fact = {data.Fact}");
        }


        public Task<FactResponse> GetName()
        {
            using (HttpClient httpClient = new HttpClient()) {
                return httpClient.GetFromJsonAsync<FactResponse>("https://catfact.ninja/fact");
            }            
        }



        public void work1()
        {
            Console.WriteLine("Started work1");
            Task.Delay(3000).Wait();
            count = 4;
            Console.WriteLine("Ended work1");
        }

        public void work2()
        {
            Console.WriteLine("Started work 2");
            Task.Delay(3000).Wait();
            count = 6;
            Console.WriteLine("Ended work 2");
        }
    }
}
