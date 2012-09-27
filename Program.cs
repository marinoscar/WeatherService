using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace WeatherService
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WeatherServiceClient();
            var result = client.GetTemperature((float) 33.481048, (float) -86.704159, new DateTime(2012, 1, 1),
                                               DateTime.Now);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
