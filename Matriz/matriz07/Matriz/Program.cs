using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] quantidade = Console.ReadLine().Split(' ');
            int N = int.Parse(quantidade[0]);
            int M = int.Parse(quantidade[1]);

            int[,] mat = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                for(int j = 0; j < M; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    if(mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Left: " + mat[i- 1, j]);
                        }
                        if (j < N -1)
                        {
                            Console.WriteLine("Left: " + mat[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Left: " + mat[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}
