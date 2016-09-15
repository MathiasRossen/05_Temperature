﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
    public class Fahrenheit : ITemperature
    {
        public double Convert(double temp)
        {
            return temp * 9 / 5 + 32;
        }
    }
}
