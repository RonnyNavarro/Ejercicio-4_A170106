using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWebRonny
{
    public class Calcular
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }
        public decimal numero3 { get; set; }
        public decimal AreaCuadrado()
        {
            return numero1 * numero1;
        }

        public decimal AreaTriangulo()
        {
            var resultadotriangulo = numero1 * numero2 / 2;
            return resultadotriangulo;
        }

        public decimal AreaCirculo()
        {
            var pi = 3.1416;
            var radioalcuadrado = Convert.ToDouble(numero1 * numero1);
            var resultadocirculo = pi * radioalcuadrado;
            return Convert.ToDecimal(resultadocirculo);
        }


    }
}