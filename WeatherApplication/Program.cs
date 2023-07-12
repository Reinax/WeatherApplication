using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();
            Console.WriteLine("Enter a Country: ");
            string cityName = Console.ReadLine();
            Console.WriteLine("City Name Entered: " + cityName);
            data.GetWeatherData(cityName);


        }
    }
}
