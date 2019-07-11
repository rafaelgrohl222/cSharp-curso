using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuicoesDeVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 6: Atribuições de Variáveis");

            Console.WriteLine();//espaço

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine("Idade: " + idade);//idade: 20
            Console.WriteLine("Idade Gustavo: " + idadeGustavo);//idade gustavo: 32

            Console.WriteLine();//espaço

            Console.WriteLine("Acabou a execução. Aperte o ENTER para SAIR...");
            Console.ReadLine();
        }
    }
}
