using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ConsoleConsumeContainer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:4000");
            var response = await Client.GetFromJsonAsync<List<Forecast>>("/WeatherForecast");
            if (response != null)
            {
                foreach (var item in response)
                {
                    Console.WriteLine($"{item.date} {item.summary} {item.temperatureC} {item.temperatureF}");
                }
            }
        }
    }
}
