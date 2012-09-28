using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using WeatherService.Models;

namespace WeatherService.UnitTests
{
    [TestFixture]
    public class WeatherDataService_Returns_Temperature
    {
        [TestFixtureSetUp]
        public void Setup()
        {

        }

        [Test]
        public IEnumerable<WeatherData> It_Try_Get_Xml_Temperature()
        {
            GeoLocation location = new GeoLocation() { Latitude = (float)33.481048, Longitude = (float)-86.704159 };
            var start = new DateTime(2004, 01, 01, 0, 0, 0);
            var end = new DateTime(2016, 09, 24, 0, 0, 0);

            var client = new WeatherServiceClient();
            var dataXml = client.GetRelativeHumidity(location.Latitude, location.Longitude, start, end);
            
            var data = new WeatherService().RelativeHumidity(location, start, end);

            Assert.IsNotNullOrEmpty(dataXml);
            return data;
        }


    }
}
