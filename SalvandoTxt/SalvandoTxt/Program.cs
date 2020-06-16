using System;
using System.IO;

namespace SalvandoTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Numero");
            int numero = int.Parse(Console.ReadLine());

            StreamWriter ficheiro  = new StreamWriter( @"C:\Users\carlo\Downloads\file.txt");
            string linha = nome + ';' + numero;
            ficheiro.WriteLine(linha);
            ficheiro.Close();


                        


        }
    }
}
