using System;
using System.Globalization;

namespace Classe04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario dados;
            dados = new Funcionario();


            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            dados.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            dados.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + dados);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.AumentoSalario(porcent);

            Console.WriteLine("Dados atualizados: " + dados);



        }
    }
}
