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
            Console.WriteLine("Podaj datę początkową w formacie: RRRR-MM-DD (późniejszą od 1999-01-01)\t");
            string startDate;
            startDate = Console.ReadLine();

            Console.WriteLine("Podaj datę końcową w formacie: RRRR-MM-DD\t");
            string endDate;
            endDate = Console.ReadLine();

            DateTime StartDate = Convert.ToDateTime(startDate);
            DateTime EndDate = Convert.ToDateTime(endDate);

            List<SeriesPerDate> listOfSeries = new List<SeriesPerDate>();

            int i = -1;
            foreach (DateTime day in EachCalendarDay(StartDate, EndDate))
            {
                Console.WriteLine(day.ToString("yyyy-MM-dd"));

                /*
                i++;

                // wysłanie rządania do serwisu API oraz zapis w zmiennej
                HttpClient client = new HttpClient();
                string call = $"https://openexchangerates.org/api/historical/{day.ToString("yyyy-mm-dd")}.json?app_id=8d4a6a6c55ad4d93896b50921077c1d9&symbols=PLN,GBP,EUR,CHF";
                string response = await client.GetStringAsync(call);

                // zapis otrzymanego jsona do pliku data.json
                await File.WriteAllTextAsync("data.json", response);

                // odczyt pliku data.json
                var json = File.ReadAllText("data.json");

                listOfSeries.Add(JsonConvert.DeserializeObject<SeriesPerDate>(json));

                Console.WriteLine(listOfSeries[i].rates.PLN + day.ToString("yyyy-mm-dd"));
                */
            }



        }

        public static IEnumerable<DateTime> EachCalendarDay(DateTime startDate, DateTime endDate)
        {
            for (var date = startDate.Date; date.Date <= endDate.Date; date = date.AddDays(1)) yield
            return date;
        }
    }
}
