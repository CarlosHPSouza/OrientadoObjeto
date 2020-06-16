using SistemaBibliotecario.Entities.Enums;
using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaBibliotecario.Entities
{
    class CadastroDeLivro
    {
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int NumeroDePagina { get; set; }
        public int ISBN { get; set; }
        public string Idioma { get; set; }
        public int Ano { get; set; }
        public string Pais { get; set; }
        public StatusLevel Level { get; set; }
        public static List<CadastroDeLivro> listCadLivro { get; set; } = new List<CadastroDeLivro>();

        public CadastroDeLivro()
        {

        }

        public CadastroDeLivro(string autor, string editora, int numeroDePagina, int iSBN, string idioma, int ano, string pais) 
        {
            Autor = autor;
            Editora = editora;
            NumeroDePagina = numeroDePagina;
            ISBN = iSBN;
            Idioma = idioma;
            Ano = ano;
            Pais = pais;
            
        }

        public static void CadLivro()
        {          

            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Editora: ");
            string editora = Console.ReadLine();
            Console.Write("Numero de Paginas: ");
            int numeroDePagina = int.Parse(Console.ReadLine());
            Console.Write("ISBN: ");
            int isbn = int.Parse(Console.ReadLine());
            Console.Write("Idioma: ");
            string idioma = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Pais: ");
            string pais = Console.ReadLine();
            

            listCadLivro.Add(new CadastroDeLivro(autor, editora, numeroDePagina, isbn, idioma, ano, pais));
            string CadastroLivroTxt = @"C:\Users\carlo\Downloads\Livro.txt";
            StreamWriter sw;
            if(File.Exists(CadastroLivroTxt)== true)
            {
                sw = File.AppendText(CadastroLivroTxt);
            }
            else
            {
                sw = File.CreateText(CadastroLivroTxt);
            }
            string linha = autor + ";" + editora + ";" + numeroDePagina + ";" + isbn + ";" + idioma + ";" + ano + ";" + pais;
            sw.WriteLine(linha);
            sw.Close();
        }
        
    }
}
