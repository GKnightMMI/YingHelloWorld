using System;


namespace ConsoleHelloWorld
{
    public class ConsumeEventSync
    {
        public void GetAllEventData() //Get All Events Records  
        {
            using (var client = new System.Net.WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:52148/api/Values/Simple"); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }
    }
}
