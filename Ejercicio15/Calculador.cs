using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculador
    {
        public static int Calcular(int num1,int num2,char operador)
        {
            int resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado= num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    if(Calculador.ValidarNum(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }
        private static bool ValidarNum(int num)
        {
            if (num != 0)
            {
                return true;
            }
            return false;
        }
    }
}
