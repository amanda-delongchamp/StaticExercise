using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 1.8) + 32;
        }
    }
}
