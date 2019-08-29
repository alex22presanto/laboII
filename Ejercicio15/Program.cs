using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            char operador;
            Console.WriteLine("Ingrese el primer operador:");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Valor no valido, ingrese el primer operador:");
            }
            Console.WriteLine("Ingrese el segundo operador:");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Valor no valido, ingrese el segundo operador:");
            }
            Console.WriteLine("Ingrese la operaciona a realizar (+, -, /, *)");
            operador = Convert.ToChar(Console.ReadLine());
            while (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                Console.WriteLine("Valor no valido, Ingrese la operaciona a realizar (+, -, /, *)");
                operador = Convert.ToChar(Console.ReadLine());
            }
            resultado = Calculador.Calcular(num1, num2, operador);
            Console.WriteLine("{0}{1}{2}={3}", num1, operador, num2, resultado);
            Console.ReadKey();
        }
    }
}
