using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 4;//informa o numero do mês

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Mes: Janeiro;");
                    break;
                case 2:
                    Console.WriteLine("Mes: fevereiro;");
                    break;
                case 3:
                    Console.WriteLine("Mes: março;");
                    break;
                default:
                    Console.WriteLine("Mês invalido.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
