using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace POSSConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = HttpClientFactory.Create();
            var url = "https://localhost:44374/api/Products/3";
            var data = await httpClient.GetStringAsync(url);
            Console.WriteLine(data);
        }
    }
}
