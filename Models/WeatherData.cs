using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherService.Models
{
    public class WeatherData
    {
        /// <summary>
        /// Name of the item to retrieve
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value for the item
        /// </summary>
        public float Value { get; set; }
    }
}
