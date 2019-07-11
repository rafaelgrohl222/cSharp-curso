using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cauculo_Condicionais_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto: Calculos, com condição Se ou Else");
            Console.WriteLine();//espaço

            double numero1;
            double numero2;
            double soma;
            String operacao;

            Console.Write("Digite o primeiro numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());//converte string em double: Convert.ToDouble

            Console.WriteLine();//espaço

            Console.Write("Digite a operação: ");
            operacao = Console.ReadLine();

            Console.WriteLine();//espaço

            Console.Write("Digite o segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());//converte string em double: Convert.ToDouble

            Console.WriteLine();//espaço

            soma = 0;

            switch (operacao)
            {
                case "+":
                    soma = numero1 + numero2;
                    Console.WriteLine("A soma é: " + soma);
                    break;

                case "-":
                    soma = numero1 - numero2;
                    Console.WriteLine("A subtração é: " + soma);
                    break;

                case "*":
                    soma = numero1 * numero2;
                    Console.WriteLine("A multiplicação é: " + soma);
                    break;

                case "/":
                    soma = numero1 / numero2;
                    Console.WriteLine("A divisão é: " + soma);
                    break;

                default:
                    break;
            }

            Console.WriteLine();//espaço

            Console.WriteLine("A execução encerrou, digite alguma letra para, SAIR!");
            Console.ReadKey();//aguardando digitar alguma letra, para Sair
        }
    }
}
