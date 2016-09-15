using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
    public class Temperature
    {
        public Temperature()
        {

        }

        public Temperature(Unit type, int temp)
        {
            celcius = temp;
            fahrenheit = temp;
        }

        private int fahrenheit, celcius;

        public int Fahrenheit
        {
            get { return fahrenheit; }
            set { fahrenheit = value; }
        }

        public int Celcius
        {
            get { return celcius; }
            set { celcius = value; }
        }

        public static double FahrenheitToCelcius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }

        public static double CelciusToFahrenheit(double temp)
        {
            return temp * 9 / 5 + 32;
        }

        
    }
}
