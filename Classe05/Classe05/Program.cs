using System;
using System.Globalization;

namespace Classe05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno dados;
            dados = new Aluno();

            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            dados.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + dados.SomaNota().ToString("F2", CultureInfo.InvariantCulture));

            if (dados.Aprovado())
            {
                Console.WriteLine("APROVDO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + dados.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}
