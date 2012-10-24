using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using WeatherService.Models;

namespace WeatherService
{
    public class WeatherService
    {
        public IEnumerable<WeatherData> GetTemperature(GeoLocation location, DateTime start, DateTime end)
        {
            var client = new WeatherServiceClient();
            return GetEnumerableWeatherDataFromService(client.GetTemperature(location.Latitude, location.Longitude, start, end), temperatureItem.Temperature);
        }

        public IEnumerable<WeatherData> RelativeHumidity(GeoLocation location, DateTime start, DateTime end)
        {
            var client = new WeatherServiceClient();
            return GetEnumerableWeatherDataFromService(client.GetRelativeHumidity(location.Latitude, location.Longitude, start, end), temperatureItem.RelativeHumidity);
        }


        protected IEnumerable<WeatherData> GetEnumerableWeatherDataFromService(string data, temperatureItem type)
        {
            var dataType = string.Empty;
            var dataName = string.Empty;

            switch (type)
            {
                case temperatureItem.Temperature:
                    dataType = "temperature";
                    break;
                case temperatureItem.RelativeHumidity:
                    dataType = "humidity";
                    break;
            }

            var xmlFile = XDocument.Parse(data);

            var firstOrDefault = (from d in xmlFile.Descendants(dataType).Elements("name")
                                  select new { ItemValue = d.Value }).FirstOrDefault();
            if (firstOrDefault != null)
                dataName = firstOrDefault.ItemValue.ToString(CultureInfo.InvariantCulture);

            var dataSelectedItems = from d in xmlFile.Descendants(dataType).Elements("value")
                                    select new { ItemValue = d.Value };

            var result = dataSelectedItems.Select(dataSelectedItem => new WeatherData() {Name = dataName, Value = float.Parse(dataSelectedItem.ItemValue)}).ToList();

            return result.AsEnumerable();
        }

    }
}
