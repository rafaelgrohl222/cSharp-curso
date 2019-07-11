using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 7: Condicionais IF");

            Console.WriteLine();//espaço

            int idadeJoao = 16;
            int quantidadePessoa = 2;

            //Início do Bloco de Condições
            if (idadeJoao >= 18)
            {
                Console.WriteLine("Você possui 18 anos, você pode entrar!" + "Sua Idade: " + idadeJoao);
            }//fim se
            else
            {
                if (quantidadePessoa >= 2)
                {
                    Console.WriteLine("Você não possue 18 anos! Mas está acompanhado! PODE ENTRAR!" + "Sua Idade: " + idadeJoao);
                }
                else
                {
                    Console.WriteLine("Você NÃO possui 18 anos! Então NÃO pode entrar!" + "Sua Idade: " + idadeJoao);
                }
            }//fim condição else
            Console.WriteLine();//espaço

            Console.WriteLine("A Execução do Projeto Finalizou, aperte ENTER para SAIR...");
            Console.ReadLine();//Aguardando o comando ENTER para sair do projeto
        }//6min40seg
    }
}
