using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Validacion
    {
        public static bool validar(char letra)
        {
            bool retorno = false;
            if (letra == 's')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
