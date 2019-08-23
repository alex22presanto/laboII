using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, year;
            int dia2, mes2, year2;
            int mesaux,diaaux;
            int acum=0;
            bool bisiesto= false;

            Console.WriteLine("ingrese el dia de nacimiento:");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el mes de nacimiento:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el año de nacimiento:");
            year = Convert.ToInt32(Console.ReadLine());
            dia2 = DateTime.Now.Day;
            mes2 = DateTime.Now.Month;
            year2 = DateTime.Now.Year;

            do
            {
                switch(mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia != 1)
                        {
                            acum += (31 - dia);
                            dia = 1;
                        }
                        else
                        {
                            acum += 31;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia != 1)
                        {
                            acum += (30 - dia);
                            dia = 1;
                        }
                        else
                        {
                            acum += 30;
                        }
                        break;
                    case 2:
                        bisiesto = VerificarBisesto(year);
                        if (bisiesto == true)
                        {
                            if (dia != 1)
                            {
                                acum += (29 - dia);
                                dia = 1;
                            }
                            else
                            {
                                acum += 29;
                            }
                        }
                        else
                        {
                            if (dia != 1)
                            {
                                acum += (28 - dia);
                                dia = 1;
                            }
                            else
                            {
                                acum += 28;
                            }
                        }
                        break;

                }
                mes++;
                if(mes>12)
                {
                    mes = 1;
                }
            }while(mes !=1);
            year++;
            while (year < year2)
            {
                bisiesto = VerificarBisesto(year);
                if (bisiesto == true)
                {
                    acum += 366;
                }
                else
                {
                    acum += 365;
                }
                year++;
            }

            do
            {
                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia != 1)
                        {
                            acum += (31 - dia);
                            dia = 1;
                        }
                        else
                        {
                            acum += 31;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia != 1)
                        {
                            acum += (30 - dia);
                            dia = 1;
                        }
                        else
                        {
                            acum += 30;
                        }
                        break;
                    case 2:
                        bisiesto = VerificarBisesto(year);
                        if (bisiesto == true)
                        {
                            if (dia != 1)
                            {
                                acum += (29 - dia);
                                dia = 1;
                            }
                            else
                            {
                                acum += 29;
                            }
                        }
                        else
                        {
                            if (dia != 1)
                            {
                                acum += (28 - dia);
                                dia = 1;
                            }
                            else
                            {
                                acum += 28;
                            }
                        }
                        break;

                }
                mes++;
                if (mes > 12)
                {
                    mes = 1;
                }
            } while (mes != mes2);
            Console.WriteLine("{0}", acum);
            Console.WriteLine("{0}", (new DateTime(1997, 07, 22) - DateTime.Now).Days);
            Console.ReadLine();
        }

        static bool VerificarBisesto(int year)
        {
            bool retorno = false;
            if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
