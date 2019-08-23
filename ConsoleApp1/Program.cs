using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            bool flag;
            Console.WriteLine("ingrese el numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for(int i=num1; i>1;i--)
            {
                flag = false;
                for (int k =i; k>1;k--)
                {
                    if(i%k==0&& k!=i)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("{0}", i);
                    Console.ReadLine();
                }
            }
        }
    }
}
