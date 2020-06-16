using System;
using Exercicio01.Entities;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Cadastro cadastro = new Cadastro(nome, idade);

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string nome01 = Console.ReadLine();
            Console.Write("Idade: ");
            int  idade01 = int.Parse(Console.ReadLine());

            cadastro = new Cadastro(nome, idade);

            if(idade > idade01)
            {
                Console.WriteLine("Pessoa mais velha: " + nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + nome01);
            }

            
        }
    }
}
