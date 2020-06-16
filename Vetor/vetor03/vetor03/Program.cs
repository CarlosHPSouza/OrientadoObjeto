using System;

namespace vetor03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            string[] valor = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                A[i] = int.Parse(valor[i]);
            }

            string[] valor2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(valor2[i]);
            }

            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");

            }
            

        }
    }
}
