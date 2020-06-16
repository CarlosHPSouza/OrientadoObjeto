using System;
using System.Globalization;

namespace vetor07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];

            for(int i = 0; i < N; i++)
            {
                string[] informacao = Console.ReadLine().Split(' ');
                nomes[i] = informacao[0];
                nota1[i] = double.Parse(informacao[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(informacao[2], CultureInfo.InvariantCulture);
            }
            
            double media = 0;
            

            Console.WriteLine("Alunos aprovados:");
            for ( int i = 0; i < N; i++)
            {
                media = (nota1[i] + nota2[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
            
        }
    }
}
