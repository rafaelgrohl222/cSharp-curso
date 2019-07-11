using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_if_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 2800.01;
            double salarioTotal;
            double porcentagem;

            if (salario >= 1900 || salario <= 2800)
            {
                porcentagem = (salario * 7.5) / 100;
                salarioTotal = (salario + porcentagem) - 142;
                Console.WriteLine("salario:" + salario);
                Console.WriteLine("Salário Total: " + salarioTotal);
                //Console.WriteLine("Porcentagem: " + porcentagem);
            }
            else
            { 
                if (salario >= 2800.01 || salario <= 3751)
                {
                    //porcentagem = (salario * 15) / 100;
                    salarioTotal = /*(salario + porcentagem) - 350 */ salario + (salario*15/100);
                    Console.WriteLine("salario:" + salario);
                    Console.WriteLine("Salário Total: " + salarioTotal);
                    //Console.WriteLine("Porcentagem: " + porcentagem);
                }

                if (salario >= 3751.01 || salario <= 4664)
                {
                    salarioTotal = salario + 22.5% - 636;
                    Console.WriteLine("salario:" + salario);
                    Console.WriteLine("Salário Total: " + salarioTotal);
                }
            }
            Console.ReadLine();
        }
    }
}
