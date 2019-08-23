using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1,contador=0,acum=0;
            do
            {
                acum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0 )
                    {
                        acum += i;
                        //Console.WriteLine("{0}", i);
                    }
                }
                if (acum == num)
                {
                    Console.WriteLine("{0}", num);
                    contador++;
                }
                num++;
            } while (contador < 4);
            Console.ReadLine();

        }
    }
}
