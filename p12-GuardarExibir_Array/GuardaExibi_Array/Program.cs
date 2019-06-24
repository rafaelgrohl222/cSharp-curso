using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardaExibi_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto: Guardar Exibir no array");
            Console.WriteLine();//espaço

            String[] nome;

            //array[nº de possições];
            nome = new String[4];

            //array[nº da possição];
            nome[0] = "Rafael";
            nome[1] = "de";
            nome[2] = "Freitas";
            nome[3] = "Brigido";

            for (int i = 0; i < 4; i++)
            {
                Console.Write(nome[i]);
                Console.Write(" ");//espaço entre os arrays
            }
            Console.WriteLine();//espaço

            Console.WriteLine();//espaço
            Console.WriteLine("O projeto encerrou, clique em um tecla, para SAIR!");
            Console.ReadKey();//aguardando clicar em qualquer letra para sair do projeto.
        }
    }
}
