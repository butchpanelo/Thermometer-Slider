using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slider
{
    public static class TemperatureConverter
    {
        public static decimal ConvertFromCelsiusToFahrenheit(decimal celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }

        public static decimal ConvertFromFahrenheitToCelsius(decimal fahrenheit)
        {
            return ((fahrenheit - 32) * 5) / 9;
        }
    }
}
