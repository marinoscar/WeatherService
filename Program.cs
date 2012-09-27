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
            //var binding = new CustomBinding();
            //binding.Elements.Add(new IsoTextMessageBindingElement("ISO-8859-1", "text/xml", MessageVersion.Soap11));
            //binding.Elements.Add(new HttpTransportBindingElement());
            //var client = ChannelFactory<IWeatherServiceClient>.CreateChannel(
            //    binding,
            //    new EndpointAddress("http://graphical.weather.gov/xml/SOAP_server/ndfdXMLserver.php"));

            //var result = client.NDFDgen((decimal) 33.481048, (decimal) -86.704159, productType.timeseries, new DateTime(2012, 1, 1),
            //               DateTime.Now, unitType.m, new weatherParametersType() {maxt = true});
            var client = new WeatherServiceClient();
            var result = client.GetTemperature((float) 33.481048, (float) -86.704159, new DateTime(2012, 1, 1),
                                               DateTime.Now);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
