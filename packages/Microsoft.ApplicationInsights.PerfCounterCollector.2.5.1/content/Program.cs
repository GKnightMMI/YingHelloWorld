using System;
using System.Net.Http;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //var helloWorldServiceAddress = new Uri("http://localhost:52148/api/Values/Simple");
            //var client = new HttpClient();
            //var result = client.GetAsync(helloWorldServiceAddress).Result;
            //var helloWorld = result.Content.ReadAsByteArrayAsync().Result;
            //Console.Write(helloWorld);
            ConsumeEventSync objsync = new ConsumeEventSync();
            objsync.GetAllEventData();
            
        }
    }
}
