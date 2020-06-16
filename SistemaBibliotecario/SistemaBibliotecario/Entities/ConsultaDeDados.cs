using System;
using System.Collections.Generic;



namespace SistemaBibliotecario.Entities 
{
    class ConsultaDeDados : CadastroDeLivro 
    {
        public static void ConsultaUsuario()
        {
            List<CadastrodeUsuario> listCadUsuario = new List<CadastrodeUsuario>();
            foreach (CadastrodeUsuario cadastrodeUsuario in listCadUsuario)
            {
                Console.WriteLine(cadastrodeUsuario.Nome + "," + cadastrodeUsuario.Idade + "," + cadastrodeUsuario.Sexo + ","
                + cadastrodeUsuario.CPF + "," + cadastrodeUsuario.CEP + "," + cadastrodeUsuario.Endereco + "," + cadastrodeUsuario.Bairro
                + "," + cadastrodeUsuario.Cidade);
            }
            
        }

        public static void ConsultarLivro()
        {           
                       
            foreach (CadastroDeLivro cadastroDeLivro in listCadLivro)
            {
                Console.WriteLine(cadastroDeLivro.Autor + "," + cadastroDeLivro.Editora + "," + cadastroDeLivro.NumeroDePagina
                    + "," + cadastroDeLivro.ISBN + "," + cadastroDeLivro.Idioma + "," + cadastroDeLivro.Idioma + "," + cadastroDeLivro.Ano
                    + "," + cadastroDeLivro.Pais);
            }
        }
    }
}
