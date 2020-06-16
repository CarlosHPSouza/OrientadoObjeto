using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaBibliotecario
{
    class CadastrodeUsuario
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public List<CadastrodeUsuario> listCadUsuario { get; set; } = new List<CadastrodeUsuario>();



        public CadastrodeUsuario()
        {

        }

        public CadastrodeUsuario(string cPF, string nome, int idade, string sexo, string cEP, string endereco, int numero, string bairro, string cidade)
        {
            CPF = cPF;
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            CEP = cEP;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }

        public void CadUsuario()
        {

            Console.Write("CPF: ");
            string cpf = (Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Sexo: ");
            string sexo = Console.ReadLine();
            Console.Write("CEP: ");
            string cep = (Console.ReadLine());
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();

            listCadUsuario.Add(new CadastrodeUsuario(cpf, nome, idade, sexo, cep, endereco, numero, bairro, cidade));
            string CadastroUsuarioTxt = @"C:\Users\carlo\Downloads\Usuario.txt";
            StreamWriter sw;
            if (File.Exists(CadastroUsuarioTxt) == true)
            {
                sw = File.AppendText(CadastroUsuarioTxt);
            }
            else
            {
                sw = File.CreateText(CadastroUsuarioTxt);
            }
            string linha = cpf + ";" + nome + ";" + idade + ";" + sexo + ";" + cep + ";" + endereco + ";" + numero + ";" + bairro + ";" + cidade;
            sw.WriteLine(linha);
            sw.Close();
        }

        public void Gravar()
        {
            string CadastroUsuarioTxt = @"C:\Users\carlo\Downloads\Usuario.txt";
            StreamWriter sw;
            if (File.Exists(CadastroUsuarioTxt) == true)
            {
                sw = File.AppendText(CadastroUsuarioTxt);
            }
            else
            {
                sw = File.CreateText(CadastroUsuarioTxt);
            }
            string linha = CPF + ";" + Nome + ";" + Idade + ";" + Sexo + ";" + CEP + ";" + Endereco + ";" + Numero 
                + ";" + Bairro + ";" + Cidade;
            sw.WriteLine(linha);
            sw.Close();

        }

    }
}


