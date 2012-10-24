using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WeatherService
{
    public class WeatherServiceClient
    {
        private readonly CustomBinding _binding;
        private readonly EndpointAddress _endpointAddress;
        private readonly IWeatherServiceClient _serviceClient;

        public WeatherServiceClient()
        {
            var serviceUrl = ConfigurationManager.AppSettings["serviceUrl"]; 
            _binding = new CustomBinding();
            _binding.Elements.Add(new IsoTextMessageBindingElement("ISO-8859-1", "text/xml", MessageVersion.Soap11));
            _binding.Elements.Add(new HttpTransportBindingElement());
            _endpointAddress = new EndpointAddress(serviceUrl);
            _serviceClient = ChannelFactory<IWeatherServiceClient>.CreateChannel(_binding,_endpointAddress);
        }

        public string GetTemperature(float latitude, float longitude, DateTime start, DateTime end)
        {
            return _serviceClient.NDFDgen((decimal)latitude, (decimal)longitude, productType.timeseries, start,
                           end, unitType.m, new weatherParametersType() { maxt = true });
        }

        public string GetRelativeHumidity(float latitude, float longitude, DateTime start, DateTime end)
        {
            return _serviceClient.NDFDgen((decimal)latitude, (decimal)longitude, productType.timeseries, start,
                           end, unitType.m, new weatherParametersType() { rh = true });
        }
        
    }
}
