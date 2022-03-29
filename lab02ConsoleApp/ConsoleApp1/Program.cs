using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string call = "https://openexchangerates.org/api/historical/2022-03-28.json?app_id=8d4a6a6c55ad4d93896b50921077c1d9&symbols=PLN,GBP,EUR,CHF";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            Console.WriteLine(response);

     

        }
    }
}
