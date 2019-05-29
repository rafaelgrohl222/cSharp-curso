using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variáveis!");
            int idade;

            idade = 32;
            Console.WriteLine(idade);//valor: 32

            idade = 10;
            Console.WriteLine(idade);//valor:10

            idade = 10 + 20;
            Console.WriteLine(idade);//valor da soma: 30

            idade = 20 - 10;
            Console.WriteLine(idade);//valor da subtração: 10

            idade = 2 * 20;
            Console.WriteLine(idade);//valor da multiplicação: 40

            idade = 10 / 2;
            Console.WriteLine(idade);//valor divisão: 5

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);//valor: 10 + (5 * 2)= 10 + 10 = (20)

            idade = (10 + 5) * 3;//soma primeiro por ordem de precedencia o "parenteses" valor: 45 
            Console.WriteLine("Sua Idade é: " + idade + "!");

            Console.WriteLine("Execução Finalizada. Tecle(ENTER) para SAIR...");
            Console.ReadLine();//Aguardando a ação (teclar o enter)
        }
    }
}
