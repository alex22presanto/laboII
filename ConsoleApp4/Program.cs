using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            //bool flag=false;
            Console.WriteLine("ingrese desde que año:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese hasta que año:");
            num2 = Convert.ToInt32(Console.ReadLine());
            while (num1 % 4 != 0 && num1 %100 != 0 && num1%400 != 0)
            {
                num1++;
            }
            Console.WriteLine("{0}", num1);
            do
            {
                num1 += 4;
                Console.WriteLine("{0}", num1);
            } while (num1<num2);
            Console.ReadLine();
        }
    }
}
