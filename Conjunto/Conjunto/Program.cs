using System;
using System.Collections.Generic;

namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int Aluno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < Aluno; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }
            Console.Write("O curso B possui quantos alunos? ");
            Aluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < Aluno; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso C possui quantos alunos? ");
            Aluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < Aluno; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.WriteLine("Total de alunos: " + Novo.Count);
            Console.ReadLine();


        }
    }
}
