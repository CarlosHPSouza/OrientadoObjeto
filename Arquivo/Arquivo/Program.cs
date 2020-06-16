using System;
using System.IO;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasta = @"C:\Users\carlo\Downloads\teste\produto.txt";
            
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(pasta);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
               
            }
            
        }
    }
}
