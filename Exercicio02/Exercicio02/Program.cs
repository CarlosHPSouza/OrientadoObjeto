using System;
using System.Globalization;
using Exercicio02.Entities;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario funcionario = new Funcionario(nome, salario);

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            string nome01 = Console.ReadLine();
            Console.Write("Salário: ");
            double salario01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario = new Funcionario(nome, salario);

            double media = (salario + salario01) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
