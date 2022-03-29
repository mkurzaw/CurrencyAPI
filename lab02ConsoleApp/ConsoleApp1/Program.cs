using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Podaj datę w formacie: RRRR-MM-DD\t");
            string date;
            date = Console.ReadLine();

            /*
            // obsługa błędu niepoprawnego formatu
            string yearString = date[0] + date[1] + date[2] + date[3];
            int tmp0 = Int32.Parse(yearString);
            int tmp1 = Convert.ToInt32(date[1]);
            int tmp2 = Convert.ToInt32(date[2]);
            int tmp3 = Convert.ToInt32(date[3]);
            int year = (tmp0*1000) + (tmp1*100) + (tmp2*10) + (tmp3);
            Console.WriteLine(tmp0);
            Console.WriteLine(tmp1);
            Console.WriteLine(year);
            */

           

            // wysłanie rządania do serwisu API oraz zapis w zmiennej
            string call = $"https://openexchangerates.org/api/historical/{date}.json?app_id=8d4a6a6c55ad4d93896b50921077c1d9&symbols=PLN,GBP,EUR,CHF";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);

            // zapis otrzymanego jsona do pliku data.json
            await File.WriteAllTextAsync("data.json", response);

            // odczyt pliku data.json
            var json = File.ReadAllText("data.json");
            Console.WriteLine(json);

            // deserializacja (nie działa)
            //List<SeriesPerDate> seriesPerDate = JsonConvert.DeserializeObject<List<SeriesPerDate>>(json);


        }
    }
}
