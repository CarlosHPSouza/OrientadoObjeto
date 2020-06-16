using System;

namespace matrix01
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] matriz = Console.ReadLine().Split(' ');
            int N = int.Parse(matriz[0]);
            int M = int.Parse(matriz[1]);

            int[,] A = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                 matriz = Console.ReadLine().Split(' ');
                for(int J = 0; J < M; J++)
                {
                    A[i, J] = int.Parse(matriz[J]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    if(A[i, j] < 0)
                    {
                        Console.WriteLine(A[i, j]);
                    }
                }
            }
            
            
        }
    }
}
