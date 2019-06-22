using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_while_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Prjeto: Calcular_while_switch");
            Console.WriteLine("Ação do Prjeto: Somar enquanto não digitar o sinal de ( = )");

            Console.WriteLine();//espaço

            double numero;
            double total;
            String operacao;

            total = 0;
            operacao = "+";

            while (operacao != "=")
            { 
            Console.Write("Entre com o valor: ");
            numero = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
                {
                    case "+": total = total + numero;
                        break;
                    case "-": total = total - numero;
                        break;
                    case "*": total = total * numero;
                        break;
                    case "/": total = total / numero;
                        break;
                    
                }
                Console.Write("Digite a Operação: ");
                operacao = Console.ReadLine();
            }
            Console.WriteLine();//espaço

            Console.Write("Resultado é: " + total);

            Console.WriteLine();//espaço

            Console.WriteLine("A execução encerrou, digite alguma telha, para SAIR!");
            Console.ReadKey();//aguardando digitar alguma tecla para SAIR!
        }
    }
}
