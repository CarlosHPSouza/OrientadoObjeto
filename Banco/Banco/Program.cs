using System;
using System.Globalization;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria p;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular a conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            string condicao = Console.ReadLine();
            if(condicao == "s")
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new ContaBancaria(numero, nome, saldo);
            }
            else
            {
                p = new ContaBancaria(numero, nome);

            }
           

            
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(p);

            
            Console.Write("Entre um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Deposito(dep);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p);

            

            Console.Write("Entre um valor para saque: ");
            double retirada = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            p.Saque(retirada);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p);

        }
    }
}
