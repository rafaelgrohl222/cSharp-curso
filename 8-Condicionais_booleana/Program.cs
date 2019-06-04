using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_booleana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 8: Condicionais Booleana");

            Console.WriteLine();//espaço

            int idadeJoao = 18;
            //int quantidadePessoa = 2;
            //bool acompanhado = quantidadePessoa >= 2;
            bool acompanhado = true;

            //se(idadeJoao for maior igual a 18 OU / || quantidadePessoa for mair igual a 2
            //if (idadeJoao >= 18 && quantidadePessoa >= 2)
            //=Tipos: ou = ||, e = &&, AND = , OR = .
            //=Tipo: true ou fause

            //Início do Bloco de Condições
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Você pode entrar!");
                Console.WriteLine("Seja bem Vindo!");
            }//fim se
            else
            {
                Console.WriteLine("Você NÃO pode entrar!");
            }//fim condição else

            /*
            if (idadeJoao >= 18 && quantidadePessoa >= 2)
            {
                Console.WriteLine("Você pode entrar!");
                Console.WriteLine("Seja bem Vindo!");
            }//fim se
            else
            {
                Console.WriteLine("Você NÃO pode entrar!");
            }//fim condição else
            */
            int idade = 68;
            bool ehIdoso = idade >= 65;
            Console.WriteLine(ehIdoso);

            Console.WriteLine();//espaço

            Console.WriteLine("A Execução do Projeto Finalizou, aperte ENTER para SAIR...");
            Console.ReadLine();//Aguardando o comando ENTER para sair do projeto
        }
    }
}