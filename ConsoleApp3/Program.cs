using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,acum1=0, acum2=0;
            Console.WriteLine("ingrese el numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i < num1; i++)
            {
                acum1 = 0;
                acum2 = 0;
                for (int j = 1; j < i; j++)
                {
                    acum1 += j;
                }
                for (int k = i+1; acum2 > acum1; k++)
                {
                    acum2 += k;
                    if (acum2 == acum1)
                    {
                        Console.WriteLine("{0}", i);
                    }
            }
            Console.ReadLine();
        }
    }
}
