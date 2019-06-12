using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPoupanca_while
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorIvestido = 1000;
            int contadorMes = 1;

            //while = enquanto, isso faça
            while (contadorMes <= 12)
            {
                valorIvestido = valorIvestido + valorIvestido * 0.0036;
                Console.WriteLine("Após N meses, você terá R$" + valorIvestido);
            }
        }
    }
}
