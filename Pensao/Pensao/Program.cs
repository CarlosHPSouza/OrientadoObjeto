using System;

namespace Pensao
{
    class Program
    {
        static void Main(string[] args)
        {

            Dados[] cliente = new Dados[10];

            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());
                        

            
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Aluguel # {i}:" );
                Console.Write("Nome: ");
                string nome  = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                cliente[quarto] = new Dados (nome, email);
                
            }

            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < 10; i++)
            {
                if(cliente[i] != null)
                {
                    Console.WriteLine(i + ":" + cliente[i]);
                }
                
            }
        }
    }
}
