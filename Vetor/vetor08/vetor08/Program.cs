using System;
using System.Globalization;

namespace vetor08
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            string[] sexo = new string[N];

            for(int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(dados[0], CultureInfo.InvariantCulture);
                sexo[i] = dados[1];
            }

            double menorAltura = altura[0];
            int posicaoAltura = 0;
            for( int i = 0; i < N; i++)
            {
                if(altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                    posicaoAltura = i;
                }
                
            }
            Console.WriteLine("Menor altura = " + altura[posicaoAltura].ToString("F2", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (altura[i] > menorAltura)
                {
                    menorAltura = altura[i];
                    posicaoAltura = i;
                }

            }
            Console.WriteLine("Maior altura = " + altura[posicaoAltura].ToString("F2", CultureInfo.InvariantCulture));

            double soma = 0.0;
            int contador = 0;
            for (int i = 0; i < N; i++)
            {
                if(sexo[i] == "F")
                {
                    soma = soma + altura[i];
                    contador++;
                }
                
            }
            double media = soma / contador;
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));

            int numeroDeHomens = 0;
            for(int i = 0; i < N; i++)
            {
                if(sexo[i] == "M")
                {
                    numeroDeHomens++;
                }
            }

            Console.WriteLine("Numero de homens = " + numeroDeHomens);
        }
    }
}
