using System;
using System.Globalization;

namespace vetor04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] valores = new double[N];


            string[] numero = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                valores[i] = double.Parse(numero[i], CultureInfo.InvariantCulture);
            }

            double soma = 0;
            int contador = 0;
            double media = 0;
            for(int i = 0; i < N; i++)
            {
                contador++;
                soma = soma + valores[i];
                media = soma / contador;
            }
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for(int i =0; i < N; i++)
            {
                if(media > valores[i])
                {
                    Console.WriteLine(valores[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
