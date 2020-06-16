using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Classe04
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double desconto()
        {
            return Salario - Imposto;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", $ " + desconto().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
