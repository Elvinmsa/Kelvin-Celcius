using System;
using System.Collections.Generic;
using System.Text;

namespace _14._12._2021.Models
{
    class Kelvin
    {
        public double Degree { get; set; }

        public Kelvin(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Kelvin(Celcius celcius)
        {
            return new Kelvin(celcius.Degree - 273.15);
        }
    }
}
