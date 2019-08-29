using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalacularCuadrado(double lado)
        {
            return lado * 2;
        }

        public static double Calaculartriangulo(double bas, double altura)
        {
            return bas*altura;
        }
        public static double CalacularCirculo(double radio)
        {
            return radio*(Math.PI);
        }
    }
}
