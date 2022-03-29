using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("data.json");

            Console.WriteLine(json);

        }
    }
}
