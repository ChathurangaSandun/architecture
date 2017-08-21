using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace architecture.Service
{
    public class LocalWeatherService : ILocalWeatherService
    {
        public string GetLocalWeatherByZip(string zip)
        {
            return "rainy weather in " + zip;
        }
    }
}