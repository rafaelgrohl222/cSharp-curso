using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 9: Escopo");

            Console.WriteLine();//espaço

            int idadeJoao = 18;
            bool acompanhado = false;
            String mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João ESTÁ acompanhado";
            }
            else
            {
                mensagemAdicional = "João Não está acompanhado";
            }

            //Início do Bloco de Condições
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Você pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }//fim se
            else
            {
                Console.WriteLine("Você NÃO pode entrar!");
                Console.WriteLine("Só pode entrar! Com Maior de 18 ou estando ACOMPANHADO");
            }//fim condição else

            Console.WriteLine();//espaço

            Console.WriteLine("A Execução do Projeto Finalizou, aperte ENTER para SAIR...");
            Console.ReadLine();//Aguardando o comando ENTER para sair do projeto
        }
    }
}
