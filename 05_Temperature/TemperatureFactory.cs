using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
    public class TemperatureFactory
    {
        public static ITemperature Get(Unit type)
        {
            switch (type)
            {
                case Unit.Celcius:
                    return new Celcius();
                case Unit.Fahrenheit:
                    return new Fahrenheit();
            }

            return new Celcius();
        }
    }
}
