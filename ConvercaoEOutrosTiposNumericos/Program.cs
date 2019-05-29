using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvercaoEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXECUTANDO O PROJETO 4");

            Console.WriteLine();//espaço

            double salario;
            salario = 1200.70;
            Console.WriteLine("Salário(double): " + salario);

            Console.WriteLine();//espaço

            //CASTING: var int recebe valor double S/ CASAS DECIMAIS
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine("Salário em Inteiro(CASTING -> var double recebe int): " + salarioEmInteiro);

            Console.WriteLine();//espaço

            //long variavel que suporta até 64bits - NÃO UTILIZADO
            long idade;
            idade = 120000000000;
            Console.WriteLine("Idade(var long - guarda grandes valores): " + idade);

            Console.WriteLine();//espaço

            //short variavel que suporta até 16bits - MAIS UTILIZADO
            short produtos;
            produtos = 15000;
            Console.WriteLine("Produtos(var short guarda pequenos valores): " + produtos);

            Console.WriteLine();//espaço

            //Float suporta casas decimais curtas
            //usa-se a letra(f) p/ afirmar que é uma variavel (float)
            float altura = 1.80f;
            Console.WriteLine("Altura(var float - guarda muitos pequenos valores ex.1.8: " + altura);

            Console.WriteLine();//espaço

            //variaveis double
            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine("Valor total(var double): " + total);

            Console.WriteLine();//espaço

            //CASTING
            double valor3 = 1.30;
            double valor4 = 1.10;
            int total2 = (int)valor3 + (int)valor4;
            Console.WriteLine("Total2 (Casting - var double recebe int): " + total2);

            Console.WriteLine();//espaço

            Console.WriteLine("Execução acabou, aperte o ENTER para sair...");
            Console.ReadLine();//Metodo que verifica - um comando de final de linha
        }
    }
}
