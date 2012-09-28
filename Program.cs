using System;
using WeatherService.Models;

namespace WeatherService
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new WeatherServiceClient();
            //var result = client.GetTemperature((float) 33.481048, (float) -86.704159, new DateTime(2012, 1, 1),
            //                                   DateTime.Now);
            //Console.WriteLine(result);
            //Console.ReadKey();


            GeoLocation location = new GeoLocation() { Latitude = (float)33.481048, Longitude = (float)-86.704159 };
            var start = new DateTime(2004, 01, 01, 0, 0, 0);
            var end = new DateTime(2016, 09, 24, 0, 0, 0);

            var data = new WeatherService().GetTemperature(location, start, end);

            data = new WeatherService().RelativeHumidity(location, start, end);
        }
    }
}
