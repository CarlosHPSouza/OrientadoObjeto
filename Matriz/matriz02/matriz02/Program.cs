using System;

namespace matriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int M = int.Parse(valores[0]);
            

            int[,] matriz = new int[M, M];

            for(int i = 0; i < M; i++)
            {
                valores = Console.ReadLine().Split(' ');
                for(int j = 0; j < M; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int[] vet = new int[M];
            
            for(int i = 0; i < M; i++)
            {
                int cont = 0;
                for (int j = 0; j < M; j++)
                {
                    cont = cont + matriz[i, j];
                }
                vet[i] = cont;
            }
            for(int i = 0; i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }
            
        }
    }
}
