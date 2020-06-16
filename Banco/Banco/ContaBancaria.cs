using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {
        public int Numero;
        public string Nome;
        public double Saldo;

        public ContaBancaria(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
           
        }

        public void Deposito (double saldo)
        {
            Saldo += saldo;
        }

        public void Saque (double saldo)
        {
            Saldo = Saldo - saldo - 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + "," + " Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
