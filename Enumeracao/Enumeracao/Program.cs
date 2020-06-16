using System;
using Enumeracao.Enties;
using Enumeracao.Enties.Enums;
using System.Globalization;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            TrabalhoCargo cargo = Enum.Parse<TrabalhoCargo>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(depName);
            Trabalho trabalho = new Trabalho(name, cargo, salarioBase, dept);

            Console.Write("How many contracts to this worker?");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valorPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int horas = int.Parse(Console.ReadLine());
                HoraContrato contrato = new HoraContrato(date, valorPorHora, horas);
                trabalho.AddContrato(contrato);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));
            Console.WriteLine("Name: " + trabalho.Name);
            Console.WriteLine("Department: " + trabalho.Departamento.Name);
            Console.WriteLine("Income for " + mesEAno + ": " + trabalho.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
