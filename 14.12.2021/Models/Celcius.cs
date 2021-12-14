using System;
using System.Collections.Generic;
using System.Text;

namespace _14._12._2021.Models
{
    class Celcius
    {
        public double Degree { get; set; }

        public Celcius(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Celcius(Kelvin kelvin)
        {
            return new Celcius(kelvin.Degree - 273.15);
        }
    }
}
