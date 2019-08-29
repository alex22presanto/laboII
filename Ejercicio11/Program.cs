using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, acum = 0,min=100,max=-100;

            bool respuesta;

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("ingrese numero");
                num = Convert.ToInt32(Console.ReadLine());
                respuesta = Validacion.Validar(num, -100, 100);
                if (respuesta == true)
                {
                    acum += num;
                    if(num<min)
                    {
                        min = num;
                    }
                    if(num>max)
                    {
                        max = num;
                    }
                }
            }
            Console.WriteLine("el promedio:{0} , minimo:{1} , maximo: {2}", acum / 10, min, max);
            Console.ReadLine();
        }
    }
}
