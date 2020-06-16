using System;
using System.Collections.Generic;
using System.Text;

namespace Classe05
{
    class Aluno
    {
        public string Nome;
        public double A;
        public double B;
        public double C;

        public double SomaNota()
        {
            return  A + B + C;

        }

        public bool Aprovado()
        {
            if(SomaNota() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - SomaNota();
            }
        }


    }
}
