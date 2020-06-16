using System;
using System.Globalization;

namespace matriz06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[,] valores = new double[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    valores[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(valores[i, j] >= 0)
                    {
                        soma = soma + valores[i, j];
                    }
                }

            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            int M = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");

            if (M == 0)
            {
                
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write(valores[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    Console.WriteLine();

                }
            }
            else if (M == 1)
            {
                for (int i = 1; i < 2; i++)
                {
                    for (int j = 0 ; j < N; j++)
                    {
                        Console.Write(valores[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    Console.WriteLine();

                }
            }
            else
            {
                for (int i = 2; i < 3; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write(valores[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    Console.WriteLine();

                }
            }

            int coluna = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");

            if (coluna == 0)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0 ; j < 1; j++)
                    {
                        Console.Write(valores[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    

                }
            }
            else if (coluna == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 1; j < 2; j++)
                    {
                        Console.Write(valores[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 2; j < 3; j++)
                    {
                        Console.Write(valores[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    
                }
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for(int i = 0; i < N; i++)
            {
                Console.Write(valores[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
                     

            
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(valores[i, j] < 0.0)
                    {
                        valores[i, j] =  valores[i, j] * valores[i, j];
                        

                    }
                }
            }

            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(valores[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
