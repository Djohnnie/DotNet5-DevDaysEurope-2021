using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace _09_SourceGenerators.Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var result = await client.GetWeatherForecast("http://localhost:5000/");

            Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}