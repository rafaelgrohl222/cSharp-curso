using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveisPontosFlutuantes_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projetp 3 - Criando Variáveis Pontos Flutuantes - Double");

            double salario;
            salario = 1200.70;
            Console.WriteLine("Salário: " + salario);//salario: 1200.7

            salario = 15 / 2;
            Console.WriteLine("Salario2 15 / 2: " + salario);//salario2: 7

            salario = 15.0 / 2;
            Console.WriteLine("Salario3 15.0 / 2: " + salario);//salario3: 7.5

            double idade;
            idade = 5 / 3;
            Console.WriteLine("Idade 5 / 3: " + idade);//idade: 1

            idade = 5.0 / 3;
            Console.WriteLine("Idade 5.0 / 3: " + idade);//idade: 1.66666666666667

            Console.WriteLine("A execução acabou. Tecle ENTER para sair...");
            Console.ReadLine();//Aguardando uma ação(Teclar enter)
        }
    }
}
