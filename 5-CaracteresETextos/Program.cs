using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5: Caracteres e Textos");

            Console.WriteLine();//espaço

            //character = caracter: recebe somente 1 caracter
            char primeiraLetra = 'a';
            Console.WriteLine("Primeira Letra: " + primeiraLetra);

            //ASCII TABLE - Basiada nesta tabela
            primeiraLetra = (char)65;
            Console.WriteLine("Primeira Letra(c/ int): " + primeiraLetra);//primeiraLetra: A

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("Primeira Letra +1: " + primeiraLetra);//primeiraletra: B

            String titulo = "Alura Cursos de Tecnologia";
            //o caracter: "@" faz uma lista ordenada
            String cursoProgramacao = 
   @" - .NET
 - Java
 - Javascript";

            Console.WriteLine();//espaço

            Console.WriteLine("Instituição: " + titulo + " " + 2020);//titulo: Alura Cursos de Tecnologia 2020
            Console.WriteLine(cursoProgramacao);

            Console.WriteLine();//espaço

            Console.WriteLine("A Execução do Projeto Finalizou Aperte o ENTER para SAIR...");
            Console.ReadLine();//Aguardando o comndo final - ENTER
        }
    }
}
