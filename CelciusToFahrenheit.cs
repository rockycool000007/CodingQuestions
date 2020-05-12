using System;

namespace CodingQuestions
{
    public class CelciusToFahrenheit
    {
        static void Main()
        {
            Console.Write("Enter the temprature to convert : ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{temperature} Celcius to {temperature.ToFahrenheit()} Fahrenheit");
            Console.WriteLine($"{temperature} Fahrenheit to {temperature.ToCelsius()} Celcius");

            Console.Read();
        }
    }

    public static class DecimalExtensions
    {
        /*
         * Formula :
         *      0 degree Celcius = 32 degree Fahrenheit Freezing/Melting point of water
         *      C to F => F = C * (9/5) + 32
         *      F to C => C = (F - 32) * (5/9)
         */

        public static double ToFahrenheit(this double temperatureInCelsius)
        {
            return Math.Round((temperatureInCelsius * 9 / 5) +32, 2);
        }

        public static double ToCelsius(this double temperatureInFahrenheit)
        {
            return Math.Round((temperatureInFahrenheit - 32) * 5 / 9, 2);
        }
    }
}