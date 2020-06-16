using System;

namespace matriz05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int N = int.Parse(entrada[0]);
            int M = int.Parse(entrada[1]);

            int[,] valores = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < M; j++)
                {
                    valores[i, j] = int.Parse(s[j]);
                }
            }

            int[,] valores2 = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                string[] A = Console.ReadLine().Split(' ');
                for(int j = 0; j < M; j++)
                {
                    valores2[i, j] = int.Parse(A[j]);
                }
            }

            int[,] soma = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                for( int j = 0; j < M; j++)
                {
                    soma[i, j] = valores[i, j] + valores2[i, j];
                    
                }
                
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(soma[i, j] + " ");
                }
                Console.WriteLine();

            }
            
        }
    }
}
