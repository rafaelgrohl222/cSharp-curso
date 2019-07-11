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
            int contadorMes = 1;//contador

            //while = enquanto, isso faça
            while (contadorMes <= 12)
            {
                valorIvestido = valorIvestido + valorIvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorIvestido);

                //contadorMes = contadorMes + 1;//soma + 1
                //contadorMes += 1;//soma(2 em 2, 3 em 3, ...), recebe e guarda + 1
                contadorMes++;//só soma + 1 e guarda na variavel
            }
            Console.WriteLine();//espaço
            Console.WriteLine("Clique no ENTER para sair!");
            Console.ReadLine();//aguardando o enter
        }
    }
}
