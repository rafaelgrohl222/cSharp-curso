﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_cauculaPoupanca2_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11: Laço de repetição For");
            Console.WriteLine();//espaço

            double valorInvestido = 1000;

            //for = laço para
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido = valorInvestido * 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá $" + valorInvestido);
            }

            Console.ReadLine();//Aguardando o clique no enter para sair.
        }
    }
}
