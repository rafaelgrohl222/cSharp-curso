using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CriarVariavelAtribuirValoresMostra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 1: Criar classe Mostrar");
            Console.WriteLine();//espaço

            contaCorrente contaDoRafael = new contaCorrente();

            contaDoRafael.titular = "Rafael";
            contaDoRafael.agencia = 001;
            contaDoRafael.conta = 001001;
            contaDoRafael.saldo = 400.1;

            Console.WriteLine("Tipo da Conta: " + contaDoRafael);
            Console.WriteLine("Titular: " + contaDoRafael.titular);
            Console.WriteLine("Agência: " + contaDoRafael.agencia);
            Console.WriteLine("Conta: " + contaDoRafael.conta);
            Console.WriteLine("Saldo: " + contaDoRafael.saldo);

            Console.WriteLine();//Espaço
            Console.WriteLine("A execução do projeto, finalizou, CLICK ENTER, para SAIR!");
            Console.ReadLine();//aguardando o comando do ENTER, para SAIR!
        }
    }
}
