using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IgualdadeTipoValorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //instância=new //objeto=ContaCorrente
            ContaCorrente contaDoRafael = new ContaCorrente();
            contaDoRafael.titular = "Rafael";
            contaDoRafael.agencia = 863;
            contaDoRafael.numero = 863001;

            ContaCorrente contaDoMike = new ContaCorrente();
            contaDoMike.titular = "Rafael";
            contaDoMike.agencia = 863;
            contaDoMike.numero = 863001;

            //Igualdade de tipo de referência
            Console.WriteLine("Igualdade de tipo de referência: " + (contaDoRafael == contaDoMike));

            Console.WriteLine();//Espaço
            //Igualdade de tipo de valor
            int idade = 27;
            int idade2 = 27;

            if (idade == idade2)
            {
                Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2) + " = Verdadeiro");
            }
            else
            {
                Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2) + " = Fauso");
            }

            Console.WriteLine();//espaço

            contaDoRafael = contaDoMike;
            Console.WriteLine(contaDoRafael == contaDoMike);

            Console.WriteLine();//espaço
            Console.WriteLine("Finalizou a execução, click ENTER, para SAIR!");
            Console.ReadLine();
        }
    }
}
