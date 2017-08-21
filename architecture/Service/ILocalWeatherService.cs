using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architecture.Service
{
    public interface ILocalWeatherService
    {
        string GetLocalWeatherByZip(string zip);
    }
}
