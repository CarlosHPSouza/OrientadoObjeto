using System;
using System.Globalization;

namespace Classe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario dados, dados1;
            dados = new Funcionario();
            dados1 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            dados.nome = Console.ReadLine();
            Console.Write("Salario: ");
            dados.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            dados1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            dados1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (dados.salario + dados1.salario) / 2.0;

            Console.WriteLine("Salario médio = " + media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
