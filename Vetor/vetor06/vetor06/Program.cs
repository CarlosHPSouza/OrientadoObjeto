using System;

namespace vetor06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] idade = new int [N];
            string[] nome = new string [N];

            
            for(int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');
                nome[i] = dados[0];
                idade[i] = int.Parse(dados[1]);
            }

            int maisvelho = 0;
            int posicaoMaiorIdade = 0;
            
            for( int i = 0; i < N; i++)
            {
                if(idade[i] > maisvelho)
                {
                    maisvelho = idade[i];
                    posicaoMaiorIdade = i;
                    
                }
            }
            
             Console.WriteLine("Pessoa mais velha: " + nome[posicaoMaiorIdade]);

        }
    }
}
