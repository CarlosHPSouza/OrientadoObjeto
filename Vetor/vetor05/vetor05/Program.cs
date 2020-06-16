using System;
using System.Globalization;
namespace vetor05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] valores = new int[N];

            string[] numeros = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                valores[i] = int.Parse(numeros[i]);
            }

            int contador = 0;
            int soma = 0;
            double media = 0;
            for(int i = 0; i < N; i++)
            {
                
                if (valores[i] % 2 == 0)
                {
                    contador++;
                    soma = soma + valores[i];
                    media = soma / contador;

                }
                
            }
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
