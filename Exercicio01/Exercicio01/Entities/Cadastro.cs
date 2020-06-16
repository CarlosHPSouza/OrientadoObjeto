using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities
{
    class Cadastro
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cadastro()
        {

        }

        public Cadastro(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
