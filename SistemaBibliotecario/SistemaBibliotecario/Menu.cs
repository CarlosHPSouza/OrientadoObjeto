using System;
using SistemaBibliotecario.Entities;




namespace SistemaBibliotecario
{
    class Menu 
    {

        static void Main(string[] args)
        {
                                 
             string sim = "s";
             string TelaOpcao = "==================  1 - Cadastro de Usuario  =================" +
                            "\n==================  2 - Cadastro de Livros   =================" +
                            "\n==================  3 - Consulta             =================" +
                            "\n==================  4 - Emprestimo           =================" +
                            "\n==================  5 - Sair                 =================";
             int opcao;
            
            

            do
            {
                Console.Clear();
                Console.WriteLine(TelaOpcao);
                Console.WriteLine("Digite uma Opção");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        new CadastrodeUsuario().CadUsuario();
                        Console.Write("Deseja cadastra outro usuario S/N: ");
                        sim = Console.ReadLine();
                        if (sim == "s")
                        {
                            new CadastrodeUsuario().CadUsuario();
                            
                        }
                        else
                        {
                            Console.WriteLine("Dados cadastrado com sucesso");
                        }
                        break;
                    case 2:

                        CadastroDeLivro.CadLivro();
                        Console.Write("Deseja cadastra outro livro S/N: ");
                        sim = Console.ReadLine();
                        if (sim == "s")
                        {
                            CadastroDeLivro.CadLivro();
                        }
                        else
                        {
                            Console.WriteLine("Dados cadastrado com sucesso");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Consultar opção 1 Usuario 2 Livro");
                        char opcaoConsulta = char.Parse(Console.ReadLine());
                        if(opcaoConsulta == 1)
                        {
                            ConsultaDeDados.ConsultaUsuario();
                        }
                        else
                        {
                            ConsultaDeDados.ConsultarLivro();
                        }
                        
                        break;

                    case 4:
                        break;

                    default:
                        break;
                                         
                }               
                                
            } while (opcao != 5);
        }        
    }
}
