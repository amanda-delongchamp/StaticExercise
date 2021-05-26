using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            double celsius = 32;
            double fahrenheit = 110;

            TempConverter.FahrenheitToCelsius(110);

            Console.WriteLine($"Convert {celsius} Celsius to Fahrenheit:  {TempConverter.CelsiusToFahrenheit(celsius)}");
            Console.WriteLine($"Convert {fahrenheit} Fahrenheit to Celsius:  {TempConverter.FahrenheitToCelsius(fahrenheit)}");
        }
    }
}
