using System;
using System.Globalization;
namespace Classe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();

           
            

            Console.WriteLine("Entre a largura e altura do retangulo:");

            ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Console.WriteLine("AREA =  " + ret.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
