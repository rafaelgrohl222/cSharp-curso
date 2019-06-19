using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto: Calculos");
            Console.WriteLine();//espaço

            double numero1;
            double numero2;
            double soma;

            Console.Write("Digite o primeiro numero: ");
            numero1 = Convert.ToDouble (Console.ReadLine());//converte string em double: Convert.ToDouble

            Console.WriteLine();//espaço

            Console.Write("Digite o segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());//converte string em double: Convert.ToDouble

            soma = numero1 + numero2;

            Console.WriteLine();//espaço

            Console.WriteLine("A soma é: " + soma);

            Console.WriteLine();//espaço

            Console.WriteLine("A execução encerrou, digite alguma letra para, SAIR!");
            Console.ReadKey();//aguardando digitar alguma letra, para Sair
        }
    }
}
