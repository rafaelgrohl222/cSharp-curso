using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digite_GuardeVariavel_ExibirTela
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomePessoa;
            String sobrenomePessoa;

            Console.WriteLine("Console: Digitar, Guardar na variável e Exibir na Tela!");
            Console.WriteLine();//espaço

            Console.WriteLine("Digite seu Nome!");
            nomePessoa = Console.ReadLine();//leu o digitado e guardou

            Console.WriteLine();//espaço

            Console.WriteLine("Digite seu Sobrenome!");
            sobrenomePessoa = Console.ReadLine();//leu o digitado e guardou

            Console.WriteLine();//espaço

            Console.WriteLine("Nome: " + nomePessoa + " " + sobrenomePessoa);

            Console.WriteLine();//espaço
            Console.WriteLine("A execução acabou, clique em qualquer tecla! Para SAIR!");
            Console.ReadKey();//Aguardar até efetuar uma ação(Clicar em qualquer tecla)
        }
    }
}
